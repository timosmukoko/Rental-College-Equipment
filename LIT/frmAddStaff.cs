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
    public partial class frmAddStaff : Form
    {
        Staff newStaff = null;
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtStaffNum.Text) && !string.IsNullOrWhiteSpace(txtStaffName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    newStaff = new Staff(txtStaffNum.Text, txtStaffName.Text, txtPassword.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Plase check your input.", "LIT Rental - Add Staff Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, try again.", "LIT Rental - Add Staff Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Staff returnStaff()
        {
            this.ShowDialog();
            return newStaff;
        }
    }
}
