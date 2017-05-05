using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RF_Control
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


            ModulatorForm frm = new ModulatorForm();
            Application.Run(new MainForm());
        }
    }
}