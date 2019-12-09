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
    public partial class frmViewStaff : Form
    {
        public frmViewStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            Staff n = addStaff.returnStaff();
            if (n != null)
            {
                Storage.UsersDB.Add(n.ID, n);
                ListViewItem item = new ListViewItem(n.getDetails());
                listStaffMembers.Items.Add(item);
            }
            MessageBox.Show("Member of staff added successfully", "LIT Rental - Staff Member Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = listStaffMembers.SelectedItems[0].SubItems[0].Text;
                frmUpdateStaff updateStaff = new frmUpdateStaff();
                Staff update = updateStaff.updateStaff(ID);
                if (update != null)
                {
                    Storage.UsersDB.Remove(ID);
                    Storage.UsersDB.Add(update.ID, update);
                    LoadStaff();
                }
                MessageBox.Show("Member of staff updated successfully", "LIT Rental - Staff Member Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Please pick a staff member", "LIT Rental - Staff Member Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Storage.UsersDB.Remove(listStaffMembers.SelectedItems[0].SubItems[0].Text);
            LoadStaff();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStaff()
        {
            listStaffMembers.Items.Clear();
            foreach (KeyValuePair<string, Person> p in Storage.UsersDB)
            {
                if (p.Value is Staff)
                {
                    Staff x = (Staff)p.Value;
                    ListViewItem lvi = new ListViewItem(x.getDetails());
                    listStaffMembers.Items.Add(lvi);
                }
            }
        }

        private void frmViewStaff_Load_1(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
