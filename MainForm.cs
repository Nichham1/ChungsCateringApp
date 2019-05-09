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

        
        Boolean isloggedin = false;
        Boolean isadmin = false;
        Boolean iscustomer = false;
        
        public void Adminloginshow()
        {

            AdminLoginForm adminlog = new AdminLoginForm();
            adminlog.MdiParent = this;
            adminlog.Show();
            isloggedin = true;
            isadmin = true;
        }

        public void Userloginshow()
        {
            UserLoginForm userlog = new UserLoginForm();
            userlog.MdiParent = this;
            userlog.Show();
            isloggedin = true;
            iscustomer = true;
        }


        private void Order_Click(object sender, EventArgs e)
        {
            //   var ctx = new ChungCateringDatabase2Entities();

            if (iscustomer == false)
            {

                Userloginshow();
            }
            else
            {

                OrderForm order = new OrderForm();
                order.MdiParent = this;
                order.Show();
            }

        }


        private void ReservationReports_Click_1(object sender, EventArgs e)
        {
            if (iscustomer == false)
            {

                Adminloginshow();
            }
            else
            {

                Resreports reservationreport = new Resreports();
                reservationreport.MdiParent = this;
                reservationreport.Show();
            }

        }
    }
}
