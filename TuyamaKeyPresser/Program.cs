using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TuyamaKeyPresser
{
    static class Program
    {
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        public static AppConfig appConfig = new AppConfig();

        public static string appConfigFile = "config.json";

        public static bool configLoaded = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load config if exists
            if (File.Exists(appConfigFile))
            {
                try
                {
                    string jsonData = File.ReadAllText(appConfigFile);
                    appConfig = JsonConvert.DeserializeObject<AppConfig>(jsonData);
                    configLoaded = true;
                }
                catch
                {
                    appConfig = new AppConfig();
                }
            }

            // Show Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
