using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CtripDataBaseDictionary
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
            //Application.Run(new Login());
            var frm = new Login();
            LoginAction(frm);
        }


        private static void LoginAction(Login myLogin)
        {
            switch (myLogin.ShowDialog())
            {
                case DialogResult.Yes:
                    Application.Run(new Main());
                    break;
                case DialogResult.Retry:
                    LoginAction(myLogin);
                    break;
                case DialogResult.None:
                default:
                    break;
            }
        }
    }
}
