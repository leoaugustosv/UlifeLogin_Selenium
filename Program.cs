using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace _1_Selenium_UlifeTest
{
    public class SeleniumCore
    {
        string selectedNav;
        string SelectedWebsite;
        string loginInput;
        string passInput;



        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public SeleniumCore()
        {
            
        }


    }
}
