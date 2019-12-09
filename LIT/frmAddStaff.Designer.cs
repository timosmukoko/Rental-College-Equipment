namespace LIT
{
    partial class frmAddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStaff));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffNum = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffNum = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.txtStaffNum);
            this.groupBox1.Controls.Add(this.lblUserPassword);
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Controls.Add(this.lblStaffNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Staff Member";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::LIT.Properties.Resources.tick_red;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(8, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Register";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(83, 19);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(144, 20);
            this.txtStaffName.TabIndex = 0;
            // 
            // txtStaffNum
            // 
            this.txtStaffNum.Location = new System.Drawing.Point(83, 45);
            this.txtStaffNum.Name = "txtStaffNum";
            this.txtStaffNum.Size = new System.Drawing.Size(144, 20);
            this.txtStaffNum.TabIndex = 1;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(5, 74);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(56, 13);
            this.lblUserPassword.TabIndex = 3;
            this.lblUserPassword.Text = "Password:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(5, 22);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(41, 13);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Name: ";
            // 
            // lblStaffNum
            // 
            this.lblStaffNum.AutoSize = true;
            this.lblStaffNum.Location = new System.Drawing.Point(5, 48);
            this.lblStaffNum.Name = "lblStaffNum";
            this.lblStaffNum.Size = new System.Drawing.Size(72, 13);
            this.lblStaffNum.TabIndex = 0;
            this.lblStaffNum.Text = "Staff Number:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LIT.Properties.Resources.user__plus;
            this.pictureBox2.Location = new System.Drawing.Point(132, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIT.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(81, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 253);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIT Rental - Add Staff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffNum;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}