using System;
using System.Windows.Forms;

namespace ChungsCateringApp
{

   
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        public Boolean isloggedin = false, isadmin = false, iscustomer = false;

        public void Adminloginshow()
        {
            AdminLoginForm adminlog = new AdminLoginForm();
            adminlog.MdiParent = this;
            adminlog.Show();
        }

        public void Userloginshow()
        {
            UserLoginForm userlog = new UserLoginForm();
            userlog.MdiParent = this;
            userlog.Show();
        }


        private void Order_Click(object sender, EventArgs e)
        {
            if (isloggedin == false)
            {
                Userloginshow();
            }
            else
            {
                if (iscustomer == true)
                {
                    OrderForm order = new OrderForm();
                    order.MdiParent = this;
                    order.Show();
                }
                else
                {
                    MessageBox.Show("invalid access");
                }
            }

        }

        private void ReservationReports_Click_1(object sender, EventArgs e)
        {
            if ( isloggedin == false)
            {
                Adminloginshow();
            }
            else
            { if (isadmin == true)
                {
                    Resreports reservationreport = new Resreports();
                    reservationreport.MdiParent = this;
                    reservationreport.Show();
                }
                else
                {
                    MessageBox.Show("invalid access");
                }
                
            }

        }

        private void ReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( isloggedin == false)
            {

                Userloginshow();
            }
            else
            {
                if ( iscustomer == true || isadmin == true) { 

                Resreports reservationreport = new Resreports();
                reservationreport.MdiParent = this;
                reservationreport.Show();
                }else
                {
                    MessageBox.Show("invalid access"); 
                }
            }

        }
    }
}
