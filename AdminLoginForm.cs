using ChungsCateringApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungsCateringApp
{
    public partial class AdminLoginForm : Form
    {
        MainForm main = new MainForm();
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            main.isadmin = true;
            main.isloggedin = true;

        }
    }
}
