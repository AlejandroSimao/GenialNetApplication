using GenialNetApplication.Forms;
using GenialNetApplication.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNetApplication
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var Entity = PreferencesDb.GetConnectionModels();
            if (Entity == null)
                Application.Run(new Form1());
            else
                Application.Run(new GenialNetApplication.Forms.Main());
        }
    }
}
