namespace LIT
{
    partial class frmResEqu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResEqu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVAEqu = new System.Windows.Forms.Button();
            this.txtKNumber = new System.Windows.Forms.TextBox();
            this.txtEPUID = new System.Windows.Forms.TextBox();
            this.lblEpuID = new System.Windows.Forms.Label();
            this.btnResIss = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickerReturn = new System.Windows.Forms.DateTimePicker();
            this.pickerIssue = new System.Windows.Forms.DateTimePicker();
            this.lblKNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVAEqu);
            this.groupBox1.Controls.Add(this.txtKNumber);
            this.groupBox1.Controls.Add(this.txtEPUID);
            this.groupBox1.Controls.Add(this.lblEpuID);
            this.groupBox1.Controls.Add(this.btnResIss);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pickerReturn);
            this.groupBox1.Controls.Add(this.pickerIssue);
            this.groupBox1.Controls.Add(this.lblKNum);
            this.groupBox1.Location = new System.Drawing.Point(13, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserve Equipment";
            // 
            // btnVAEqu
            // 
            this.btnVAEqu.Image = global::LIT.Properties.Resources.application_list1;
            this.btnVAEqu.Location = new System.Drawing.Point(97, 30);
            this.btnVAEqu.Name = "btnVAEqu";
            this.btnVAEqu.Size = new System.Drawing.Size(33, 23);
            this.btnVAEqu.TabIndex = 14;
            this.btnVAEqu.UseVisualStyleBackColor = true;
            this.btnVAEqu.Click += new System.EventHandler(this.btnVAEqu_Click);
            // 
            // txtKNumber
            // 
            this.txtKNumber.Location = new System.Drawing.Point(136, 32);
            this.txtKNumber.Name = "txtKNumber";
            this.txtKNumber.Size = new System.Drawing.Size(121, 20);
            this.txtKNumber.TabIndex = 13;
            // 
            // txtEPUID
            // 
            this.txtEPUID.Location = new System.Drawing.Point(9, 32);
            this.txtEPUID.Name = "txtEPUID";
            this.txtEPUID.ReadOnly = true;
            this.txtEPUID.Size = new System.Drawing.Size(82, 20);
            this.txtEPUID.TabIndex = 12;
            // 
            // lblEpuID
            // 
            this.lblEpuID.AutoSize = true;
            this.lblEpuID.Location = new System.Drawing.Point(6, 16);
            this.lblEpuID.Name = "lblEpuID";
            this.lblEpuID.Size = new System.Drawing.Size(85, 13);
            this.lblEpuID.TabIndex = 11;
            this.lblEpuID.Text = "Equipment ID(s):";
            // 
            // btnResIss
            // 
            this.btnResIss.Image = global::LIT.Properties.Resources.tick_red;
            this.btnResIss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResIss.Location = new System.Drawing.Point(9, 97);
            this.btnResIss.Name = "btnResIss";
            this.btnResIss.Size = new System.Drawing.Size(248, 23);
            this.btnResIss.TabIndex = 9;
            this.btnResIss.Text = "???";
            this.btnResIss.UseVisualStyleBackColor = true;
            this.btnResIss.Click += new System.EventHandler(this.btnResIss_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Return Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Issue Date:";
            // 
            // pickerReturn
            // 
            this.pickerReturn.Location = new System.Drawing.Point(136, 71);
            this.pickerReturn.Name = "pickerReturn";
            this.pickerReturn.Size = new System.Drawing.Size(121, 20);
            this.pickerReturn.TabIndex = 6;
            // 
            // pickerIssue
            // 
            this.pickerIssue.Location = new System.Drawing.Point(9, 71);
            this.pickerIssue.Name = "pickerIssue";
            this.pickerIssue.Size = new System.Drawing.Size(121, 20);
            this.pickerIssue.TabIndex = 5;
            this.pickerIssue.ValueChanged += new System.EventHandler(this.pickerIssue_ValueChanged);
            // 
            // lblKNum
            // 
            this.lblKNum.AutoSize = true;
            this.lblKNum.Location = new System.Drawing.Point(133, 16);
            this.lblKNum.Name = "lblKNum";
            this.lblKNum.Size = new System.Drawing.Size(94, 13);
            this.lblKNum.TabIndex = 3;
            this.lblKNum.Text = "Student KNumber:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIT.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(94, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmResEqu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResEqu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIT Rental -";
            this.Load += new System.EventHandler(this.frmResEqu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKNum;
        private System.Windows.Forms.Button btnResIss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickerReturn;
        private System.Windows.Forms.DateTimePicker pickerIssue;
        private System.Windows.Forms.TextBox txtKNumber;
        private System.Windows.Forms.TextBox txtEPUID;
        private System.Windows.Forms.Label lblEpuID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVAEqu;
    }
}