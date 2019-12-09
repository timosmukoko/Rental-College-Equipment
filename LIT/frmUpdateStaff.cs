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
    public partial class frmUpdateStaff : Form
    {
        Staff currentSelected = null;
        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStaffNumber.Text) && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                currentSelected.ID = txtStaffNumber.Text;
                currentSelected.Name = txtName.Text;
                currentSelected.Password = txtPassword.Text;
                this.Close();
            }else
            {
                MessageBox.Show("Please check your input.", "LIT Rental - Staff Member Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Staff updateStaff(string id)
        {
            currentSelected = (Staff)Storage.UsersDB[id];
            txtStaffNumber.Text = currentSelected.ID;
            txtName.Text = currentSelected.Name;
            txtPassword.Text = currentSelected.Password;
            this.ShowDialog();
            return currentSelected;
        }
    }
}
