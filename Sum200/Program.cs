// Author : Chavela Rios
// Date   : 2020-09-23
// Chapter 5 exercise 9 Sum200

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sum200
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
            Application.Run(new frmMain());
        }
    }
}
