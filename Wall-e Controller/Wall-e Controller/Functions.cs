using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wall_e_Controller
{
    public static class Functions
    {

        private static string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e\\settings.txt";

        public static string GetSettingValue(string name)
        {
            string[] settings = File.ReadAllLines(settingsPath);

            foreach (string s in settings)
            {
                string[] parts = s.Split(':');

                if (parts.Length == 2)
                {
                    if (parts[0] == name)
                    {
                        return parts[1];
                    }
                }else
                {
                    return null;
                }
            }

            return null;
        }

        public static void SetSettingValue(string name, string value)
        {
            string[] settings = File.ReadAllLines(settingsPath);

            bool found = false;
            for (int i = 0; i < settings.Length; i++)
            {
                string[] parts = settings[i].Split(':');
                if (parts.Length == 2 && parts[0] == name)
                {
                    settings[i] = name + ":" + value;
                    found = true;
                }
            }

            if (!found)
            {
                string[] oldSettings = settings;
                settings = new string[settings.Length + 1];

                for (int i = 0; i < oldSettings.Length; i++)
                {
                    settings[i] = oldSettings[i];
                }

                settings[settings.Length - 1] = name + ":" + value;
            }

            File.WriteAllLines(settingsPath, settings);
        }
    }
}
