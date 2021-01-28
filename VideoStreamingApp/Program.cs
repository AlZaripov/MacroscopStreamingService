using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoStreamingApp.BL;

namespace VideoStreamingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            mainForm.AddCameras();
            
#region Add resolution 
            //Несколько стандартных видео разрешений различных форматов (4:3, 5:3, 16:9)
            mainForm.AddResolution(new Resolution(320, 240));
            mainForm.AddResolution(new Resolution(400, 240));
            mainForm.AddResolution(new Resolution(640, 360));

            mainForm.AddResolution(new Resolution(640, 480));
            mainForm.AddResolution(new Resolution(800, 480));
            mainForm.AddResolution(new Resolution(960, 540));
           
            mainForm.AddResolution(new Resolution(1024, 768));
            mainForm.AddResolution(new Resolution(1280, 768));
            mainForm.AddResolution(new Resolution(1280, 720));
#endregion

            Application.Run(mainForm);
        }
    }
}
