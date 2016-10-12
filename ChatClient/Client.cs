using System;
using System.Windows.Forms;

namespace ChatClient
{
    static class Client
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new MainForm();
            Application.Run(form);
        }
    }
}
