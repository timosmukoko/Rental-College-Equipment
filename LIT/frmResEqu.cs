using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Shane Nolan - K00205031.
namespace LIT
{
    public partial class frmResEqu : Form
    {
        List<Equipment> EquipmentTrans = new List<Equipment>();
        Transaction nTrans = null;
        bool option = true;
        public frmResEqu()
        {
            InitializeComponent();
        }

        public Tuple<Transaction, string> reserveEquipment(List<Equipment> Equipments, bool option)
        {
            EquipmentTrans = Equipments;
            this.option = option;
            //If option is true then the user wants to reserve equipment.
            //Else they want to issue equipment.
            if (option)
            {
                this.Text += " Reserve Equipment";
                btnResIss.Text = "Reserve";
            }
            else
            {
                this.Text += " Issue Equipment";
                btnResIss.Text = "Issue";
                pickerIssue.Enabled = false;
                pickerReturn.Enabled = false;
            }
            MaxDate();
            this.ShowDialog();
            return Tuple.Create(nTrans, txtKNumber.Text);
        }

        private void btnVAEqu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of Equipment:\n" + EID("ID: ", "\n", true), "LIT Rental - Equipments", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string EID(string title, string sep, bool showname)
        {
            string detail = "";
            int count = EquipmentTrans.Count > 5 ? 5 : EquipmentTrans.Count;
            // For loop is used incase the student reserves a lot of equipment.
            // Therefore preventing a long messagebox.
            for (int x = 0; x < count; x++)
            {
                //It's the little things that count. :) -> Removes sep ',' at end.
                sep = x == count - 1 ? "" : sep;
                if(showname)
                    detail += title + EquipmentTrans[x].id + " " + EquipmentTrans[x].name + sep;
                else
                    detail += title + EquipmentTrans[x].id + sep;
            }

            if (count > 5)
                detail += "\nAnd " + (EquipmentTrans.Count - 5).ToString() + " more equipment(s)."; 

            return detail;
        }

        private void frmResEqu_Load(object sender, EventArgs e)
        {
            txtEPUID.Text = EID("", ",", false);
        }

        private void MaxDate()
        {
            //Max Reserve Date is the Minimum Issue Date out of the Equipment List.
            /*e.g. Equipment 1 has a max booking for 3 days and Equipment 2 has a maxbooking
             * of 2 days. Therefore the MaxDate is equal to two.*/
            int max = EquipmentTrans[0].maxbooking;
            foreach(Equipment x in EquipmentTrans)
            {
                max = x.maxbooking < max ? x.maxbooking : max;
            }
            pickerReturn.MaxDate = pickerIssue.Value.AddDays(max);
            pickerReturn.Value = pickerIssue.Value.AddDays(max);
        }

        private void btnResIss_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtKNumber.Text))
                {
                    if (CheckID(txtKNumber.Text.Trim()))
                    {
                        nTrans = new Transaction(IDGenerate(), pickerIssue.Value, pickerReturn.Value);
                        foreach (Equipment x in EquipmentTrans)
                        {
                            nTrans.addItem(x);
                            x.linkedStudent = (Student)Storage.UsersDB[txtKNumber.Text];
                        }

                        this.Close();
                    }
                    else
                        MessageBox.Show("The ID: " + txtKNumber.Text.Trim() + " doesn't exist.",
                            "LIT Rental - Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong :(. Try again.", "LIT Rental - Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pickerIssue_ValueChanged(object sender, EventArgs e)
        {
            MaxDate();
        }

        //Generates a unique ID using Microsofts GUID.
        private string IDGenerate()
        {
            Guid guild = Guid.NewGuid();
            string id = Convert.ToBase64String(guild.ToByteArray());
            id = id.Replace("=", "");
            id = id.Replace("+", "");

            return id;
        }

        /*Checks if a users ID exists.
         * Would have made a class of validation but I felt it wasn't necessary.*/
        private bool CheckID(string ID)
        {
            if (Storage.UsersDB[ID] != null)
                return true;
            return false;
        }
    }
}
