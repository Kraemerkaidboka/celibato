using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestordeestudantesTessete
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new form_login());

            form_login form_Login = new form_login();

            if (form_Login.ShowDialog() == DialogResult.OK )
            {
                Application.Run(new form_login());
            }
            else 
            {
            Application.Exit();
            }
        }
    }
}
