using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _1_Selenium_UlifeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxSite.SelectedIndex = 0;
        }

        private void cbxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSite.SelectedIndex == 0)
            {
                SeleniumCore.selectedWebsite = "Sala Virtual";
            }

            else if (cbxSite.SelectedIndex > 0)
            {
                SeleniumCore.selectedWebsite = "Portal";
            }

        }

        private void rdbChrome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbChrome.Checked)
            {
                SeleniumCore.selectedNav = "Chrome";
            }

        }

        private void rdbFirefox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFirefox.Checked)
            {
                SeleniumCore.selectedNav = "Firefox";
            }
        }

        private void rdbEdge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEdge.Checked)
            {
                SeleniumCore.selectedNav = "Edge";
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SeleniumCore.loginInput = txtLogin.Text;
            SeleniumCore.passInput = txtSenha.Text;


            var web = new SeleniumCore();
            web.TestWeb();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
