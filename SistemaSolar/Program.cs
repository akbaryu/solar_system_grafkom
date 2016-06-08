
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaSolar
{
    static class Program
    {
        static int status = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
