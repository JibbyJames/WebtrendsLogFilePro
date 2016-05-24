using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    static class Program
    {
        // Important Global Variables
        public static string InputFilePath = "";
        public static string OutputPath = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogFileProForm());
        }
    }
}
