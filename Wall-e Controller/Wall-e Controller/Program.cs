using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wall_e_Controller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e");
            }

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e\\settings.txt"))
            {
                string[] lines = { "arduino-com:COM0", "ip-address:192.168.1.2", "left-motor-offset:100", "right-motor-offset:100", "inverse-steering:false" };
                File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wall-e\\settings.txt", lines);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
