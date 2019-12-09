using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Storage.ImportUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Staff x = (Staff)Storage.UsersDB[txtStaffNum.Text];
                if (txtPassword.Text == x.Password)
                {
                    //MessageBox.Show("You are logged in successfully!", "LIT Rental - Successful Login");
                    frmRptEpu rptEqu = new frmRptEpu();
                    rptEqu.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("It appears your Staff ID or Password is incorrect! Please try again!", "LIT Rental - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("It appears your Staff ID or Password is incorrect! Please try again!", "LIT Rental - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
