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
    public partial class frmViewStudents : Form
    {
        public frmViewStudents()
        {
            InitializeComponent();
        }

        private void frmViewStudents_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listStudent.SelectedItems.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                bool found = false;
                foreach (KeyValuePair<string, Person> student in Storage.UsersDB)
                {
                    if (student.Value.ID == txtSearch.Text)
                    {
                        listStudent.Items[0].Selected = true;
                        listStudent.Select();
                        found = true;
                    }
                }

                if (found == false)
                {
                    MessageBox.Show("Invalid Student ID, try again.", "LIT Rental - Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadStudent()
        {
            listStudent.Items.Clear();
            foreach (KeyValuePair<string, Person> p in Storage.UsersDB)
            {
                if (p.Value is Student)
                {
                    Student a = (Student)p.Value;
                    ListViewItem lvi = new ListViewItem(a.getDetails());
                    listStudent.Items.Add(lvi);
                }
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0)
            {
                string ID = listStudent.SelectedItems[0].SubItems[0].Text;
                Student curr = (Student)Storage.UsersDB[ID];
                frmAccTrans viewTrans = new frmAccTrans(curr);
                viewTrans.Show();
            }else
            {
                MessageBox.Show("Please select a Student.", "LIT Rental - Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
