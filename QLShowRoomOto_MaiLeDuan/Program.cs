﻿using System;
using System.Windows.Forms;

namespace QLShowRoomOto_MaiLeDuan
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
            Application.Run(new frm_Intro());
        }
    }
}
