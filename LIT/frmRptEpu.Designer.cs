namespace LIT
{
    partial class frmRptEpu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptEpu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReturned = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvEpuRpt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkOD = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStaffDash = new System.Windows.Forms.Button();
            this.btnEpuDash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStuDash = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lvEpuRpt);
            this.groupBox1.Controls.Add(this.checkOD);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Report";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::LIT.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(375, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReturned);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Controls.Add(this.btnIssue);
            this.groupBox2.Controls.Add(this.btnReserve);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(375, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 186);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnReturned
            // 
            this.btnReturned.Enabled = false;
            this.btnReturned.Image = global::LIT.Properties.Resources.box__arrow;
            this.btnReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturned.Location = new System.Drawing.Point(6, 99);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(140, 23);
            this.btnReturned.TabIndex = 4;
            this.btnReturned.Text = "Process Returned";
            this.btnReturned.UseVisualStyleBackColor = true;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::LIT.Properties.Resources.box_search_result;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(9, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Equipment(s):";
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Image = global::LIT.Properties.Resources.truck_box;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(6, 157);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(140, 23);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Image = global::LIT.Properties.Resources.box;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(6, 128);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(140, 23);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "_______________________";
            // 
            // lvEpuRpt
            // 
            this.lvEpuRpt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEpuRpt.FullRowSelect = true;
            this.lvEpuRpt.GridLines = true;
            this.lvEpuRpt.Location = new System.Drawing.Point(6, 19);
            this.lvEpuRpt.Name = "lvEpuRpt";
            this.lvEpuRpt.Size = new System.Drawing.Size(363, 180);
            this.lvEpuRpt.TabIndex = 0;
            this.lvEpuRpt.UseCompatibleStateImageBehavior = false;
            this.lvEpuRpt.View = System.Windows.Forms.View.Details;
            this.lvEpuRpt.SelectedIndexChanged += new System.EventHandler(this.lvEpuRpt_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Max Booking";
            this.columnHeader4.Width = 74;
            // 
            // checkOD
            // 
            this.checkOD.AutoSize = true;
            this.checkOD.Enabled = false;
            this.checkOD.Location = new System.Drawing.Point(6, 205);
            this.checkOD.Name = "checkOD";
            this.checkOD.Size = new System.Drawing.Size(178, 17);
            this.checkOD.TabIndex = 0;
            this.checkOD.Text = "Show Overdue Equipment only?";
            this.checkOD.UseVisualStyleBackColor = true;
            this.checkOD.CheckedChanged += new System.EventHandler(this.checkOD_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStuDash);
            this.groupBox3.Controls.Add(this.btnStaffDash);
            this.groupBox3.Controls.Add(this.btnEpuDash);
            this.groupBox3.Location = new System.Drawing.Point(120, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 44);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigation";
            // 
            // btnStaffDash
            // 
            this.btnStaffDash.Location = new System.Drawing.Point(150, 15);
            this.btnStaffDash.Name = "btnStaffDash";
            this.btnStaffDash.Size = new System.Drawing.Size(126, 23);
            this.btnStaffDash.TabIndex = 0;
            this.btnStaffDash.Text = "Staff Dashboard";
            this.btnStaffDash.UseVisualStyleBackColor = true;
            this.btnStaffDash.Click += new System.EventHandler(this.btnStaffDash_Click);
            // 
            // btnEpuDash
            // 
            this.btnEpuDash.Location = new System.Drawing.Point(6, 15);
            this.btnEpuDash.Name = "btnEpuDash";
            this.btnEpuDash.Size = new System.Drawing.Size(126, 23);
            this.btnEpuDash.TabIndex = 1;
            this.btnEpuDash.Text = "Equipment Dashboard";
            this.btnEpuDash.UseVisualStyleBackColor = true;
            this.btnEpuDash.Click += new System.EventHandler(this.btnEpuDash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIT.Properties.Resources.LogoNew;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnStuDash
            // 
            this.btnStuDash.Location = new System.Drawing.Point(293, 15);
            this.btnStuDash.Name = "btnStuDash";
            this.btnStuDash.Size = new System.Drawing.Size(126, 23);
            this.btnStuDash.TabIndex = 2;
            this.btnStuDash.Text = "Student Dashboard";
            this.btnStuDash.UseVisualStyleBackColor = true;
            this.btnStuDash.Click += new System.EventHandler(this.btnStuDash_Click);
            // 
            // frmRptEpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptEpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIT Rental - Report on Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRptEpu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvEpuRpt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkOD;
        private System.Windows.Forms.Button btnReturned;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStaffDash;
        private System.Windows.Forms.Button btnEpuDash;
        private System.Windows.Forms.Button btnStuDash;
    }
}