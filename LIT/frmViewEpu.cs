using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace LIT
{
    public partial class frmViewEpu : Form
    {
        Equipment newEquip = null;
        private string SAVE_DIR = Directory.GetCurrentDirectory() + "\\Res\\";
        public frmViewEpu()
        {
            InitializeComponent();

            Storage.ImportEquipment();
            LoadEquipment();
        }

        private void LoadEquipment()
        {
            list_View.Items.Clear();
            foreach (Equipment epu in Storage.EquipmentDB)
            {
                ListViewItem lvi = new ListViewItem(epu.ViewsDetails());
                list_View.Items.Add(lvi);
            }
            pictureBox.Image = LIT.Properties.Resources.package;
        }

        // Clear inpu txt
        private void ClearAdd()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtMaxBooking.Text = "";
            pictureBox.Image = null;
        }

        // display TO LISTVIEW
        private void AddToListViews(string ID, string name, int maxB)
        {
            //Row
            string[] row = { ID, name, maxB.ToString() };
            ListViewItem item = new ListViewItem(row);

            //Add Items
            list_View.Items.Add(item);
        }

        // Add new Equipment into file
        private void AddNewEqu()
        {
            newEquip = new Equipment();
            newEquip.id = txtID.Text;
            newEquip.name = txtName.Text;
            newEquip.maxbooking = Convert.ToInt16(txtMaxBooking.Text);
            newEquip.ImageLocation = SAVE_DIR + txtID.Text;
            Storage.EquipmentDB.Add(newEquip);
            newEquip = null;
            txtID.Text = "";
            txtName.Text = "";
            txtMaxBooking.Text = "";
            //BinaryWriter bw = new BinaryWriter(File.OpenWrite("EquipDB.bin"));

            //foreach (Equipment equ in Storage.EquipmentDB)
            //{
            //    bw.Write(newEquip.id);
            //    bw.Write(newEquip.name);
            //    bw.Write(newEquip.maxbooking);

            //   bw.Dispose();
            //    Storage.EquipmentDB.Add(newEquip);
            //}
        }

        // Delete Item into Database                        
        private void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "LIT Rental - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Storage.EquipmentDB.RemoveAt(list_View.SelectedIndices[0]);
                list_View.Items.Remove(list_View.SelectedItems[0]);
                ClearAdd();
                //groupBoxAdd.Enabled = false;
                MessageBox.Show(" The Record is Deleted !", "INFO");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(" The Record is not Deleted !", "INFO");
                txtID.Focus();
            }

        }

        // Update Item into Database
        private void update()
        {
            try
            {
                if (list_View.SelectedItems.Count != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record ? ", "LIT Rental - Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        list_View.SelectedItems[0].SubItems[0].Text = txtID.Text;
                        list_View.SelectedItems[0].SubItems[1].Text = txtName.Text;
                        list_View.SelectedItems[0].SubItems[2].Text = txtMaxBooking.Text;

                        Storage.EquipmentDB.RemoveAt(list_View.SelectedIndices[0]);
                        list_View.Items.Remove(list_View.SelectedItems[0]);

                        AddNewEqu();

                        //Storage.EquipmentDB.RemoveAt(list_View.SelectedIndices[0]);
                        //list_View.Items.Remove(list_View.SelectedItems[0]);
                        //list_View.Items.Add(list_View.SelectedItems[0]);
                        LoadEquipment();
                        MessageBox.Show(" Equipment is update ");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show(" This Record is not updated !", "INFO");
                        txtID.Focus();
                    }
                }else
                {
                    MessageBox.Show("Please select an Equipment.", "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exs)
            {
                MessageBox.Show("Error:" + exs.Message, "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Load data from file (EquipDB.bin)
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        // Update specific item
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        // Delete specific item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        // Exit()
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Search item by ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            list_View.SelectedItems.Clear();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                bool found = false;
                foreach (Equipment epu in Storage.EquipmentDB)
                {
                    if (epu.id == txtSearch.Text.Trim())
                    {
                        list_View.Items[Storage.EquipmentDB.IndexOf(epu)].Selected = true;
                        list_View.Select();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        //Fill listview from dataview
        //private void populateListView(DataView dv)
        //{
        //    list_View.Items.Clear();
        //    foreach (DataRow row in dv.ToTable().Rows)
        //    {
        //        list_View.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));

        //    }
        //}

        //Perform filtering
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dv.RowFilter = string.Format("ID Like '%{0}%'", txtSearch.Text);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmViewEpu_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            txtID.Focus();

            list_View.FullRowSelect = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearAdd();
            groupBoxAdd.Enabled = true;
            txtID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "" && txtName.Text != "" && txtMaxBooking.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this record? ", "LIT Rental - Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //AddToListViews(txtID.Text, txtName.Text, Convert.ToInt32(txtMaxBooking.Text));
                        //groupBoxAdd.Enabled = false;
                        MessageBox.Show(" New Equipment is Added ", "INFO");
                        AddToListViews(txtID.Text, txtName.Text, Convert.ToInt32(txtMaxBooking.Text));
                        AddNewEqu();
                        //Storage.ExportEquipment();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show(" The Record is not stored !", "INFO");
                        txtID.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Read Me - " + ex.Message);
            }
        }

        private void tbnClear_Click(object sender, EventArgs e)
        {
            list_View.Items.Clear();
            ClearAdd();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*gif)|*.jpg;*png;*gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);

                if (!Directory.Exists(SAVE_DIR))
                    Directory.CreateDirectory(SAVE_DIR);

                File.Copy(opf.FileName, SAVE_DIR+txtID.Text, true);
            }
        }

        private void list_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_View.SelectedItems.Count == 1)
            {
                Equipment temp = Storage.EquipmentDB[list_View.SelectedIndices[0]];
                txtID.Text = temp.id;
                txtName.Text = temp.name;
                txtMaxBooking.Text = temp.maxbooking.ToString();
                pictureBox.ImageLocation = temp.ImageLocation;
            }
        }
    }
}
