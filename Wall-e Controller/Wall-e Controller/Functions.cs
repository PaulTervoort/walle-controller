using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Wall_e_Controller
{
    public static class Functions
    {
        private static string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e\\settings.txt";

        static Dictionary<string, string> settings = new Dictionary<string, string>();
        static bool loadedSettings = false;

        public static string GetSettingValue(string name)
        {
            if (!loadedSettings)
            {
                string[] settingsFile = File.ReadAllLines(settingsPath);
                settings = new Dictionary<string, string>();

                foreach (string s in settingsFile)
                {
                    string[] parts = s.Split(':');

                    if (parts.Length == 2)
                    {
                        settings.Add(parts[0], parts[1]);
                    }
                }

                loadedSettings = true;
            }

            string returnValue;
            if(!settings.TryGetValue(name, out returnValue)) { returnValue = null; }

            return returnValue;
        }

        public static void SetSettingValue(string name, string value)
        {
            if(settings.ContainsKey(name))
            {
                settings[name] = value;
            }
            else
            {
                settings.Add(name, value);
            }

            string[] saveSettings = new string[settings.Count];
            for(int i = 0; i < saveSettings.Length; i++)
            {
                KeyValuePair<string, string> setting = settings.ElementAt(i);
                saveSettings[i] = setting.Key + ":" + setting.Value;
            }
           

            File.WriteAllLines(settingsPath, saveSettings);
        }
    }
}
