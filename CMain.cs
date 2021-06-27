using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GestorComprobantes
{
    static class CMain
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        static public CBaseDatos Base;
        //static public SQLiteConnection cnmain;

        [STAThread]
        static void Main()
        {
            Base = new CBaseDatos();

            if (Base==null)
            {
                Application.Exit();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        
    }
}
