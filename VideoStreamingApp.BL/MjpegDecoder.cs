using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStreamingApp.BL
{
    public static class MjpegDecoder
    {
        private static bool isStartMarker;

        /// <summary>
        /// Основные маркеры JPEG
        /// https://ru.wikipedia.org/wiki/JPEG
        /// </summary>
        private const int startMarkerByte = 0xFF;       //255
        private const int startImageByte = 0xD8;        //216
        private const int endImageByte = 0xD9;          //217

        private static bool pictureByte;
        private static List<byte> betweenJPEGList = new List<byte>();
        private static string time;

        #region
        public static async Task GetByteArray(Action<byte[], string> action, string URL, CancellationToken token)
        {
            using (var client = new HttpClient())
            {
                byte[] streamByteArray = new byte[1024];
                List<byte> imageByteList = new List<byte>();
                

                using (var stream = await client.GetStreamAsync(URL))
                {
                    while (!token.IsCancellationRequested)
                    {
                        var streamLength = await stream.ReadAsync(streamByteArray, 0, streamByteArray.Length);
                        DetectBytes(streamByteArray, imageByteList, streamLength, action);
                    }
                }
            }
        }

        // Распознаем байты из потока
        private static void DetectBytes(byte[] array, List<byte> list, int streamLength, Action<byte[], string> action)
        {
            for (int i = 0; i < streamLength; i++)
            {
                byte b = array[i];

                if (b == startMarkerByte)
                    isStartMarker = true;
                else if (isStartMarker && b == startImageByte)
                    DetectStartImageByte(list);
                else if (isStartMarker && b == endImageByte)
                    DetectEndImageByte(list, action);
                else if (!pictureByte)
                    betweenJPEGList.Add(b);
                else
                    DetectDataImageByte(list, b);                
            }
        }

        // Нашли байт, свидетельствующий о начале изображения
        private static void DetectStartImageByte(List<byte> list)
        {
            string str = System.Text.Encoding.UTF8.GetString(betweenJPEGList.ToArray());
            var array = str.Split(new string[] { "Timestamp" }, StringSplitOptions.None);
            time = array[1].Substring(0, array[1].Length - 8).Remove(0, 2);

            pictureByte = true;
            list.Clear();
            list.Add(startMarkerByte);
            list.Add(startImageByte);
            isStartMarker = false;
        }

        // Нашли байт, свидетельствующий о конце изображения
        private static void DetectEndImageByte(List<byte> list, Action<byte[], string> action)
        {
            betweenJPEGList.Clear();
            pictureByte = false;

            list.Add(startMarkerByte);
            list.Add(endImageByte);

            action(list.ToArray(), time);
        }

        // Нашли байт с данными изображения
        private static void DetectDataImageByte(List<byte> list, byte b)
        {
            if (isStartMarker)
            {
                list.Add(startMarkerByte);
                isStartMarker = false;
            }
            list.Add(b);
        }

        #endregion
    }
}
