using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TuyamaKeyPresser
{
    class AppConfig
    {
        public string ProcessName = "chrome";
        public string KeyCode = "F5";
        public int Interval = 60 * 20; // Interval in seconds

        public bool Save()
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(this);
                File.WriteAllText(Program.appConfigFile, jsonData);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
