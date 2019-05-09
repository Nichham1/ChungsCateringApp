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
    public partial class UserLoginForm : Form
    {
        MainForm main = new MainForm();
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            String Username;
            String Password;
            Password = TBpassword.Text;
            Username = TBpassword.Text;

            if (Username=="" || Password == "")
            {
                MessageBox.Show("invalid information");
            }
            else
            {
                main.isloggedin = true;
                main.iscustomer = true;
            }

          
        }
    }
}
