using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace VideoStreamingApp.BL
{
    public class Channels : IEnumerable
    {
        private List<ChannelInfo> ChannelList { get; }

        public Channels(string configFilePath)
        {
            ChannelList = GetConfigXML(configFilePath);        
        }

        // Получаем ID по имени канала
        public string GetID(string Name)
        {
            foreach (var item in ChannelList)
                if (item.Name == Name)
                    return item.ID;
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in ChannelList)
                yield return item.Name;
        }

        // Заполняем список данными из XML
        private static List<ChannelInfo> GetConfigXML(string path)
        {
            var serializer = new XmlSerializer(typeof(ConfigurationXML));
            try
            {
                using (var reader = XmlReader.Create(path))
                {
                    ConfigurationXML config = (ConfigurationXML)serializer.Deserialize(reader);
                    return config.Chanels; ;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ChannelInfo> { };
            }  
        }
    }
}
