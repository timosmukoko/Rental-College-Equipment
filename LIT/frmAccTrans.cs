using System;
using System.Windows.Forms;

// Shane Nolan - K00205031.
namespace LIT
{
    public partial class frmAccTrans : Form
    {
        Student currStudent = null;
        public frmAccTrans(Student s)
        {
            InitializeComponent();
            currStudent = s;
            gbAccTrans.Text += s.ID;
        }

        private void frmAccTrans_Load(object sender, EventArgs e)
        {
            foreach(Transaction x in currStudent.getTransaction())
            {
                ListViewItem lvi = new ListViewItem(x.Details());
                lvAccTrans.Items.Add(lvi);
            }
        }
    }
}
