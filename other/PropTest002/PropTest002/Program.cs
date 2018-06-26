using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PropTest002
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //第一种方式
            //Application.Run(new Form1());

            //第二种方式
            Application.Run(new Form2());
        }
    }
}