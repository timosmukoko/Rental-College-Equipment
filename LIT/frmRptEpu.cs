using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Shane Nolan - K00205031.
namespace LIT
{
    public partial class frmRptEpu : Form
    {
        public frmRptEpu()
        {
            InitializeComponent();

            #region Hardcoded 
            /*
            Staff tStaff = new Staff("S01", "Mary Jane", "Password");
            Staff tStaffTwo = new Staff("S02", "John Wayne", "Password123");
            Staff tStaffThree = new Staff("S03", "Shane Nolan", "Pass");
            Student tStudentOne = new Student("K00205031", "Shaneee Kiid", "LOL");

            Storage.UsersDB.Add(tStaffThree.ID, tStaffThree);
            Storage.UsersDB.Add(tStaff.ID, tStaff);
            Storage.UsersDB.Add(tStaffTwo.ID, tStaffTwo);
            Storage.UsersDB.Add(tStudentOne.ID, tStudentOne);

            Equipment epu = new Equipment("E01", "Canon", Status.Overdue, 3);
            Equipment epuTwo = new Equipment("E02", "Canon", Status.Issued, 3);
            Equipment epuThree = new Equipment("E03", "Pi", Status.Available, 2);
            epu.linkedStudent = tStudentOne;
            epuTwo.linkedStudent = tStudentOne;
            epuThree.linkedStudent = tStudentOne;
            Storage.EquipmentDB.Add(epu);
            Storage.EquipmentDB.Add(epuTwo);
            Storage.EquipmentDB.Add(epuThree);

            Transaction ntrans = new Transaction("001", DateTime.Now, DateTime.Now.AddDays(3));
            ntrans.addItem(epu);
            ntrans.addItem(epuTwo);
            tStudentOne.addTransaction(ntrans);*/
            #endregion

            Storage.ImportUsers();
            Storage.ImportEquipment();
            LoadEquipment();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Loads Equipment from Storage || Check for OVERDUE Equipment.
        private void LoadEquipment()
        {
            lvEpuRpt.Items.Clear();
            if (Storage.EquipmentDB.Count != 0)
            {
                foreach (Equipment epu in Storage.EquipmentDB)
                {
                    ListViewItem lvi = new ListViewItem(epu.Details());
                    lvEpuRpt.Items.Add(lvi);
                }
                IsOverDue();
                GUIBTN();
                checkOD.Enabled = true;
            }
        }

        //Displays a list of OVERDUE Equipment.
        private void checkOD_CheckedChanged(object sender, EventArgs e)
        {
            lvEpuRpt.SelectedItems.Clear();
            GUIBTN();
            if (checkOD.Checked)
            {
                lvEpuRpt.Items.Clear();
                foreach (Equipment epu in Storage.EquipmentDB)
                {
                    if (epu.stat == Status.Overdue)
                    {
                        ListViewItem lvi = new ListViewItem(epu.Details());
                        lvEpuRpt.Items.Add(lvi);
                    }
                }
            }
            else
                LoadEquipment();
        }

        private void btnStaffDash_Click(object sender, EventArgs e)
        {
            frmViewStaff frmStaff = new frmViewStaff();
            frmStaff.Show();
        }

        private void btnEpuDash_Click(object sender, EventArgs e)
        {
            frmViewEpu frmEpu = new frmViewEpu();
            frmEpu.ShowDialog();
            LoadEquipment();
        }

        //Seach for Equipment via its ID then highlight it.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvEpuRpt.SelectedItems.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                bool found = false;
                foreach(Equipment epu in Storage.EquipmentDB)
                {
                    if (epu.id == txtSearch.Text.Trim())
                    {
                        lvEpuRpt.Items[Storage.EquipmentDB.IndexOf(epu)].Selected = true;
                        lvEpuRpt.Select();
                        found = true;
                    }
                }

                if (!found)
                    MessageBox.Show("Equipment ID: " + txtSearch.Text + ", was not found.", "LIT Rental - Search", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Please enter in an Equipment ID.", "LIT Rental - Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Button Layout depending on the selected Equipment.
        private void GUIBTN()
        {
            if (lvEpuRpt.SelectedItems.Count != 0)
            {
                if (Storage.EquipmentDB[lvEpuRpt.SelectedIndices[0]].stat == Status.Available)
                {
                    btnReturned.Enabled = false;
                    btnIssue.Enabled = true;
                    btnReserve.Enabled = true;
                }
                else if (Storage.EquipmentDB[lvEpuRpt.SelectedIndices[0]].stat == Status.Reserved)
                {
                    btnIssue.Enabled = true;
                    btnReserve.Enabled = false;
                    btnReturned.Enabled = true;
                }
                else
                {
                    btnIssue.Enabled = false;
                    btnReserve.Enabled = false;
                    btnReturned.Enabled = true;
                }
            }
            else
            {
                btnIssue.Enabled = false;
                btnReserve.Enabled = false;
                btnReturned.Enabled = false;
            }
        }

        //GUI Modifcation to button.
        private void lvEpuRpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUIBTN();
            if (lvEpuRpt.SelectedItems.Count == 1)
            {
                if (CheckStatus(Status.Returned))
                    btnReturned.Text = "Make Available";
                else
                    btnReturned.Text = "Process Returned";
            }
        }

        /* If the Button's text says Make Available then Check the selected equipment,
         * if they are ALL returned then make them available and update the display.
         * 
         * Otherwise check the selected and make sure its status is ISSED or OVERDUE,
         * if so update them as returned and update the display. */
        private void btnReturned_Click(object sender, EventArgs e)
        {
            if (btnReturned.Text == "Make Available")
            {
                if (CheckStatus(Status.Returned))
                {
                    if (CheckTransaction())
                    {
                        ChangeStatus(Status.Available);
                        LoadEquipment();
                    }
                }
                else
                {
                    MessageBox.Show("One or more of the selected equipments are not ready to be made available.",
                        "LIT Rental - Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lvEpuRpt.SelectedItems.Clear();
                }
            }
            else
            {
                if (CheckStatus(Status.Issued) || CheckStatus(Status.Overdue))
                {
                    if (CheckTransaction())
                    {
                        ChangeStatus(Status.Returned);
                        LoadEquipment();
                        if (checkOD.Checked)
                            checkOD.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("One or more of the selected equipments are not able to be returned.",
                       "LIT Rental - Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lvEpuRpt.SelectedItems.Clear();
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (lvEpuRpt.SelectedItems.Count != 0)
                CreateTransaction(true);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (lvEpuRpt.SelectedItems.Count != 0)
                CreateTransaction(false);
        }

        /* Create a transaction with the option of it being a reserved transaction(TRUE) or an issued transaction(FALSE).
         * Put each selected item into a list, then display the reserve/issue form depending on the users option.
         *      The form returns a transaction and the users ID associated with it. Add the transaction to the users
         *      transactions and then change the equipments status. The equipment is linked to the student in the 
         *      other form. */
        private void CreateTransaction(bool option)
        {
            try
            {
                List<Equipment> transEpu = new List<Equipment>();
                for (int x = 0; x < lvEpuRpt.SelectedItems.Count; x++)
                    transEpu.Add(Storage.EquipmentDB[lvEpuRpt.SelectedIndices[x]]);

                frmResEqu frmREpu = new frmResEqu();
                Tuple<Transaction, string> transInfo = frmREpu.reserveEquipment(transEpu, option);
                if (transInfo.Item1 != null)
                {
                    Student s = (Student)Storage.UsersDB[transInfo.Item2];
                    s.addTransaction(transInfo.Item1);
                    if (option)
                        ChangeStatus(transEpu, Status.Reserved);
                    else
                        ChangeStatus(transEpu, Status.Issued);
                    LoadEquipment();
                }
                else
                    lvEpuRpt.SelectedItems.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show("Transaction was unable to be created. Error: " + ex.GetType(), 
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Check the Equipments Status.
        private bool CheckStatus(Status value)
        {
            for(int x = 0; x < lvEpuRpt.SelectedItems.Count; x++)
            {
                if (Storage.EquipmentDB[lvEpuRpt.SelectedIndices[x]].stat != value)
                    return false;
            }
            return true;
        }

        //Change the Equipments Status via a passed in Status Value.
        private void ChangeStatus(Status value)
        {
            for(int x = 0; x < lvEpuRpt.SelectedItems.Count; x++)
                Storage.EquipmentDB[lvEpuRpt.SelectedIndices[x]].stat = value;
        }

        //Change the Equipments Status by a passed in list with a passed in Status Value.
        private void ChangeStatus(List<Equipment> list, Status value)
        {
            foreach(Equipment x in list)
                x.stat = value;
        }

        //When the form is closing, save/export the equipment and users.
        private void frmRptEpu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Storage.ExportEquipment();
            Storage.ExportUsers();
            Application.Exit();
        }

        //Check for OVERDUE Equipment by comparing its Return Date with Todays Date.
        private void IsOverDue()
        {
            foreach(KeyValuePair<string, Person> kvp in Storage.UsersDB)
            {
                if (kvp.Value is Student)
                {
                    Student current = (Student)kvp.Value;
                    foreach (Transaction t in current.getTransaction())
                    {
                        if (!t.closed)
                            if (t.ReturnDate > DateTime.Now)
                                ChangeStatus(t.Items, Status.Overdue);
                    }
                }
            }
        }

        /*Return items grouped together to prevent errors. Such as OVERDUE bug i.e
         *  Transaction A is created with Equipment A and B. Equipment A is returned.
         *  Then a new Transaction is created, Transaction B. Transaction B contains Equipment A and B.
         *  Transaction A's equipment becomes OVERDUE, therefore if we were to set each equipment in that transaction
         *      as overdue it would also make Equipment B OVERDUE but it shouldnt since Equipment B is in an entirely new
         *      transaction.
         *      
         *Therefore this function prevents that bug from occuring:
         *  It checks each select item and stores the equipments linked student, it then fetches the students open transactions
         *      and then checks if the transaction contains one of the selected equipments. If it does notify them that the Student
         *      must also return the other equipment taken out at the same time as that equipment.*/
        private bool CheckTransaction()
        {
            try
            {
                for (int x = 0; x < lvEpuRpt.SelectedItems.Count; x++)
                {
                    Student current = Storage.EquipmentDB[lvEpuRpt.SelectedIndices[x]].linkedStudent;
                    foreach (Transaction t in current.getTransaction())
                    {
                        if (!t.closed)
                        {
                            if (t.Items.Contains(Storage.EquipmentDB[lvEpuRpt.SelectedIndices[x]]))
                            {
                                string list = "";
                                foreach (Equipment e in t.Items)
                                {
                                    list += e.id + " " + e.name + " ";
                                }

                                DialogResult dr = MessageBox.Show("Equipments: " + list + "need to be returned together." +
                                    "\nWould you like to continue?", "LIT Rental - Return Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (dr == DialogResult.Yes)
                                {
                                    foreach (Equipment e in t.Items)
                                    {
                                        ListViewItem lvi = lvEpuRpt.FindItemWithText(e.id);
                                        int index = lvEpuRpt.Items.IndexOf(lvi);

                                        if (!lvEpuRpt.SelectedIndices.Contains(index))
                                            lvEpuRpt.SelectedIndices.Add(index);
                                    }
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong trying to confirm the Transaction. Error: " + ex.GetType(),
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnStuDash_Click(object sender, EventArgs e)
        {
            frmViewStudents vStudents = new frmViewStudents();
            vStudents.Show();
        }
    }
}
