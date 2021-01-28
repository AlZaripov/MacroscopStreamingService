using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using VideoStreamingApp.BL;
using System.IO;
using System.Configuration;
using System.Collections.Generic;

namespace VideoStreamingApp
{
    public partial class MainForm : Form
    {
        bool streamIsStarted;           // Видео трансляция началась
        Channels chanels;

        string selectedCamera;
        Resolution res;
        int fps;
        string url;

        Label timestamp;

        public Dictionary<string, string> dict;
        DateTime dt;
        
        CancellationTokenSource cts;
        CancellationToken token;
        
        public MainForm()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
            token = cts.Token;
            chanels = new Channels(ConfigurationManager.AppSettings["configXML"]);

            dict = new Dictionary<string, string>
            {
                { "RealTimeVideo", "Видео в режиме реального времени" },
                { "ArchiveVideo", "Видео из архива" }
            };

            AddStreamingModes();

            btnStartStreaming.Click += StartStreaming;
            btnStopStreaming.Click += StopStreaming;
            btnPauseStreaming.Click += PauseStreaming;
            btnApply.Click += ApplyChanges;
            streamingModeSelector.SelectedIndexChanged += SelectMode;

            //Параметры лейбла
            timestamp = new Label();
            timestamp.Location = new Point(10, 10);
            timestamp.Size = new Size(648, 20);
            timestamp.ForeColor = Color.White;
            timestamp.BackColor = Color.Black;
            timestamp.Font = new Font("Microsoft Sans Serif", 10);
            timestamp.Visible = false;
            timestamp.TextAlign = ContentAlignment.MiddleLeft;
            timestamp.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            Controls.Add(timestamp);
            timestamp.BringToFront();

            for (int i = 30; i > 0; i--)
                fpsSelector.Items.Add(i.ToString());
        }

        private void PauseStreaming(object sender, EventArgs e)
        {
            streamIsStarted = false;
            cts.Cancel();
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            if (CameraSelector.SelectedItem != null && ResolutionSelector.SelectedItem != null && fpsSelector.Text != "" && streamingModeSelector.Text != "")
            {
                selectedCamera = CameraSelector.Text;
                res = Resolution.GetResolution(ResolutionSelector.Text);
                fps = int.Parse(fpsSelector.Text);
                dt = dtSelector.Value;
                
                // Формируем запрос исходя из режима видео 
                if(streamingModeSelector.Text == dict["RealTimeVideo"])
                    url = GetUrl(selectedCamera, res, fps);
                else
                    url = GetUrl(dt, selectedCamera, res, fps);
                    
                if (streamIsStarted)
                {
                    PauseStreaming(sender, e);
                    StartStreaming(sender, e);
                }  
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void StopStreaming(object sender, EventArgs e)
        {
            PauseStreaming(sender, e);
            pictureBox.Image = null;
            timestamp.Visible = false;  
            pictureBox.BackColor = System.Drawing.SystemColors.Control;
        }

        private async void StartStreaming(object sender, EventArgs e)
        {
            // Сбрасываем токен для возможности возобновления трансляции
            if (token.IsCancellationRequested)
            {
                cts = new CancellationTokenSource();
                token = cts.Token;
            }

            if (!streamIsStarted && selectedCamera != null && res != null && fpsSelector.Text != "" && url != null)
            {
                pictureBox.BackColor = Color.Black;
                streamIsStarted = true;

                await MjpegDecoder.GetByteArray(DrawImage, url, token);
            }
            else if (!streamIsStarted && url!=null)
                MessageBox.Show("Пожалуйста, заполните все поля и нажмите \"Применить\"", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SelectMode(object sender, EventArgs e)
        {
            if (streamingModeSelector.Text == dict["RealTimeVideo"])
                dtSelector.Enabled = false;
            else
                dtSelector.Enabled = true;
        }

        // Отрисовка картинки
        public void DrawImage(byte[] array, string time)
        {
            timestamp.Visible = true;
            timestamp.Text = time + " (UTC +00:00)";
            timestamp.Refresh();

            using (var ms = new MemoryStream(array))
            {
                pictureBox.Image = new Bitmap(ms);
            }
        }

        #region Добавление элементов на форму
        // Добавляем список камер в список на форму
        public void AddCameras()
        {
            foreach(var item in chanels)
                CameraSelector.Items.Add(item);
        }

        // Добавляем список разрешений
        public void AddResolution(Resolution res)
        {
            ResolutionSelector.Items.Add(res.ToString());
        }

        // Добавляем выбор режима видеотрасляции
        public void AddStreamingModes()
        {
            foreach(var record in dict)
                streamingModeSelector.Items.Add(record.Value);
        }
        #endregion

        #region Конкатенация URL адреса
        private string GetUrl(string SelectedCamera, Resolution res, int fps)
        {
            return $"{ConfigurationManager.AppSettings.Get("site")}:" +
                 $"{ConfigurationManager.AppSettings.Get("port")}/mobile?login=" +
                 $"{ConfigurationManager.AppSettings.Get("defaultLogin")}" +
                 $"&channelid={chanels.GetID(SelectedCamera)}" +
                 $"&resolutionX={res.X}&resolutionY={res.Y}&fps={fps}";
        }

        private string GetUrl(DateTime dt, string SelectedCamera, Resolution res, int fps)
        {
            if (dt.TimeOfDay >= DateTime.Now.TimeOfDay && dt.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Время архивной записи не может превышать текущее", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }              
            var date = dt.ToUniversalTime().ToString("dd/MM/yyyy+HH:mm:ss");
           
            return $"{ConfigurationManager.AppSettings.Get("site")}:" +
                 $"{ConfigurationManager.AppSettings.Get("port")}/mobile?mode=archive&startTime={date}&login=" +
                 $"{ConfigurationManager.AppSettings.Get("defaultLogin")}" +
                 $"&channelid={chanels.GetID(SelectedCamera)}" +
                 $"&resolutionX={res.X}&resolutionY={res.Y}&fps={fps}";
        }
        #endregion
    }
}
