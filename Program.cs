﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaXD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación
        /// </summary>
        [STAThread]
        static void Main()
        {
            //pene
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
