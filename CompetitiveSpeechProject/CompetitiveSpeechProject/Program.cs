using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompetitiveSpeechProject
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
            Main fLogin = new Main();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Exit();
                     
            }
        }
    }
}
