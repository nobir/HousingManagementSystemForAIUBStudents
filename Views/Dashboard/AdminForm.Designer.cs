namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabSearchUser = new System.Windows.Forms.TabPage();
            this.errMsgSearchUser = new System.Windows.Forms.Label();
            this.gbSearchUser = new System.Windows.Forms.GroupBox();
            this.errMsgSearchUserEmail = new System.Windows.Forms.Label();
            this.tbSearchUserEmail = new System.Windows.Forms.TextBox();
            this.lbSearchUserEmail = new System.Windows.Forms.Label();
            this.lbSearchUserType = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.gbLoginUserType = new System.Windows.Forms.GroupBox();
            this.rbSearchUserRenter = new System.Windows.Forms.RadioButton();
            this.rbSearchUserTenant = new System.Windows.Forms.RadioButton();
            this.tabDeleteUser = new System.Windows.Forms.TabPage();
            this.actionMsgDeleteUser = new System.Windows.Forms.Label();
            this.errMsgDeleteUserEmail = new System.Windows.Forms.Label();
            this.tbDeleteUserEmail = new System.Windows.Forms.TextBox();
            this.lbDeleteUserEmail = new System.Windows.Forms.Label();
            this.lbDeleteUserType = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDeleteUserRenter = new System.Windows.Forms.RadioButton();
            this.rbDeleteUserTenant = new System.Windows.Forms.RadioButton();
            this.tabControlAdmin.SuspendLayout();
            this.tabSearchUser.SuspendLayout();
            this.gbLoginUserType.SuspendLayout();
            this.tabDeleteUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabSearchUser);
            this.tabControlAdmin.Controls.Add(this.tabDeleteUser);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(4, 4);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(774, 545);
            this.tabControlAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.TabStop = false;
            // 
            // tabSearchUser
            // 
            this.tabSearchUser.Controls.Add(this.errMsgSearchUser);
            this.tabSearchUser.Controls.Add(this.gbSearchUser);
            this.tabSearchUser.Controls.Add(this.errMsgSearchUserEmail);
            this.tabSearchUser.Controls.Add(this.tbSearchUserEmail);
            this.tabSearchUser.Controls.Add(this.lbSearchUserEmail);
            this.tabSearchUser.Controls.Add(this.lbSearchUserType);
            this.tabSearchUser.Controls.Add(this.btnSearchUser);
            this.tabSearchUser.Controls.Add(this.gbLoginUserType);
            this.tabSearchUser.Location = new System.Drawing.Point(4, 30);
            this.tabSearchUser.Name = "tabSearchUser";
            this.tabSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchUser.Size = new System.Drawing.Size(766, 511);
            this.tabSearchUser.TabIndex = 0;
            this.tabSearchUser.Text = "Search User";
            this.tabSearchUser.UseVisualStyleBackColor = true;
            // 
            // errMsgSearchUser
            // 
            this.errMsgSearchUser.AutoSize = true;
            this.errMsgSearchUser.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgSearchUser.ForeColor = System.Drawing.Color.Red;
            this.errMsgSearchUser.Location = new System.Drawing.Point(215, 211);
            this.errMsgSearchUser.Name = "errMsgSearchUser";
            this.errMsgSearchUser.Size = new System.Drawing.Size(192, 29);
            this.errMsgSearchUser.TabIndex = 17;
            this.errMsgSearchUser.Text = "User Not Found!!!";
            this.errMsgSearchUser.Visible = false;
            // 
            // gbSearchUser
            // 
            this.gbSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbSearchUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSearchUser.Location = new System.Drawing.Point(3, 265);
            this.gbSearchUser.Name = "gbSearchUser";
            this.gbSearchUser.Size = new System.Drawing.Size(760, 243);
            this.gbSearchUser.TabIndex = 16;
            this.gbSearchUser.TabStop = false;
            this.gbSearchUser.Tag = "";
            // 
            // errMsgSearchUserEmail
            // 
            this.errMsgSearchUserEmail.AutoSize = true;
            this.errMsgSearchUserEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgSearchUserEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgSearchUserEmail.Location = new System.Drawing.Point(155, 70);
            this.errMsgSearchUserEmail.Name = "errMsgSearchUserEmail";
            this.errMsgSearchUserEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgSearchUserEmail.TabIndex = 15;
            // 
            // tbSearchUserEmail
            // 
            this.tbSearchUserEmail.Location = new System.Drawing.Point(159, 39);
            this.tbSearchUserEmail.Name = "tbSearchUserEmail";
            this.tbSearchUserEmail.Size = new System.Drawing.Size(293, 28);
            this.tbSearchUserEmail.TabIndex = 1;
            this.tbSearchUserEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchUserEmail_KeyUp);
            // 
            // lbSearchUserEmail
            // 
            this.lbSearchUserEmail.AutoSize = true;
            this.lbSearchUserEmail.Location = new System.Drawing.Point(28, 46);
            this.lbSearchUserEmail.Name = "lbSearchUserEmail";
            this.lbSearchUserEmail.Size = new System.Drawing.Size(48, 21);
            this.lbSearchUserEmail.TabIndex = 13;
            this.lbSearchUserEmail.Text = "Email";
            // 
            // lbSearchUserType
            // 
            this.lbSearchUserType.AutoSize = true;
            this.lbSearchUserType.Location = new System.Drawing.Point(28, 137);
            this.lbSearchUserType.Name = "lbSearchUserType";
            this.lbSearchUserType.Size = new System.Drawing.Size(78, 21);
            this.lbSearchUserType.TabIndex = 12;
            this.lbSearchUserType.Text = "User Type";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Enabled = false;
            this.btnSearchUser.Location = new System.Drawing.Point(544, 32);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(150, 35);
            this.btnSearchUser.TabIndex = 5;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // gbLoginUserType
            // 
            this.gbLoginUserType.Controls.Add(this.rbSearchUserRenter);
            this.gbLoginUserType.Controls.Add(this.rbSearchUserTenant);
            this.gbLoginUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbLoginUserType.Location = new System.Drawing.Point(159, 113);
            this.gbLoginUserType.Name = "gbLoginUserType";
            this.gbLoginUserType.Size = new System.Drawing.Size(269, 58);
            this.gbLoginUserType.TabIndex = 2;
            this.gbLoginUserType.TabStop = false;
            // 
            // rbSearchUserRenter
            // 
            this.rbSearchUserRenter.AutoSize = true;
            this.rbSearchUserRenter.Location = new System.Drawing.Point(179, 20);
            this.rbSearchUserRenter.Name = "rbSearchUserRenter";
            this.rbSearchUserRenter.Size = new System.Drawing.Size(77, 25);
            this.rbSearchUserRenter.TabIndex = 4;
            this.rbSearchUserRenter.Text = "Renter";
            this.rbSearchUserRenter.UseVisualStyleBackColor = true;
            // 
            // rbSearchUserTenant
            // 
            this.rbSearchUserTenant.AutoSize = true;
            this.rbSearchUserTenant.Checked = true;
            this.rbSearchUserTenant.Location = new System.Drawing.Point(7, 20);
            this.rbSearchUserTenant.Name = "rbSearchUserTenant";
            this.rbSearchUserTenant.Size = new System.Drawing.Size(86, 25);
            this.rbSearchUserTenant.TabIndex = 3;
            this.rbSearchUserTenant.TabStop = true;
            this.rbSearchUserTenant.Text = "Student";
            this.rbSearchUserTenant.UseVisualStyleBackColor = true;
            // 
            // tabDeleteUser
            // 
            this.tabDeleteUser.Controls.Add(this.actionMsgDeleteUser);
            this.tabDeleteUser.Controls.Add(this.errMsgDeleteUserEmail);
            this.tabDeleteUser.Controls.Add(this.tbDeleteUserEmail);
            this.tabDeleteUser.Controls.Add(this.lbDeleteUserEmail);
            this.tabDeleteUser.Controls.Add(this.lbDeleteUserType);
            this.tabDeleteUser.Controls.Add(this.btnDeleteUser);
            this.tabDeleteUser.Controls.Add(this.groupBox1);
            this.tabDeleteUser.Location = new System.Drawing.Point(4, 30);
            this.tabDeleteUser.Name = "tabDeleteUser";
            this.tabDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteUser.Size = new System.Drawing.Size(766, 511);
            this.tabDeleteUser.TabIndex = 1;
            this.tabDeleteUser.Text = "Delete User";
            this.tabDeleteUser.UseVisualStyleBackColor = true;
            // 
            // actionMsgDeleteUser
            // 
            this.actionMsgDeleteUser.AutoSize = true;
            this.actionMsgDeleteUser.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.actionMsgDeleteUser.Location = new System.Drawing.Point(215, 211);
            this.actionMsgDeleteUser.Name = "actionMsgDeleteUser";
            this.actionMsgDeleteUser.Size = new System.Drawing.Size(192, 29);
            this.actionMsgDeleteUser.TabIndex = 22;
            this.actionMsgDeleteUser.Text = "User Not Found!!!";
            this.actionMsgDeleteUser.Visible = false;
            // 
            // errMsgDeleteUserEmail
            // 
            this.errMsgDeleteUserEmail.AutoSize = true;
            this.errMsgDeleteUserEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgDeleteUserEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgDeleteUserEmail.Location = new System.Drawing.Point(155, 70);
            this.errMsgDeleteUserEmail.Name = "errMsgDeleteUserEmail";
            this.errMsgDeleteUserEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgDeleteUserEmail.TabIndex = 21;
            // 
            // tbDeleteUserEmail
            // 
            this.tbDeleteUserEmail.Location = new System.Drawing.Point(159, 39);
            this.tbDeleteUserEmail.Name = "tbDeleteUserEmail";
            this.tbDeleteUserEmail.Size = new System.Drawing.Size(293, 28);
            this.tbDeleteUserEmail.TabIndex = 16;
            this.tbDeleteUserEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDeleteUserEmail_KeyUp);
            // 
            // lbDeleteUserEmail
            // 
            this.lbDeleteUserEmail.AutoSize = true;
            this.lbDeleteUserEmail.Location = new System.Drawing.Point(28, 46);
            this.lbDeleteUserEmail.Name = "lbDeleteUserEmail";
            this.lbDeleteUserEmail.Size = new System.Drawing.Size(48, 21);
            this.lbDeleteUserEmail.TabIndex = 20;
            this.lbDeleteUserEmail.Text = "Email";
            // 
            // lbDeleteUserType
            // 
            this.lbDeleteUserType.AutoSize = true;
            this.lbDeleteUserType.Location = new System.Drawing.Point(28, 137);
            this.lbDeleteUserType.Name = "lbDeleteUserType";
            this.lbDeleteUserType.Size = new System.Drawing.Size(78, 21);
            this.lbDeleteUserType.TabIndex = 19;
            this.lbDeleteUserType.Text = "User Type";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(544, 32);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteUser.TabIndex = 18;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeleteUserRenter);
            this.groupBox1.Controls.Add(this.rbDeleteUserTenant);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(159, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 58);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbDeleteUserRenter
            // 
            this.rbDeleteUserRenter.AutoSize = true;
            this.rbDeleteUserRenter.Location = new System.Drawing.Point(179, 20);
            this.rbDeleteUserRenter.Name = "rbDeleteUserRenter";
            this.rbDeleteUserRenter.Size = new System.Drawing.Size(77, 25);
            this.rbDeleteUserRenter.TabIndex = 4;
            this.rbDeleteUserRenter.Text = "Renter";
            this.rbDeleteUserRenter.UseVisualStyleBackColor = true;
            // 
            // rbDeleteUserTenant
            // 
            this.rbDeleteUserTenant.AutoSize = true;
            this.rbDeleteUserTenant.Checked = true;
            this.rbDeleteUserTenant.Location = new System.Drawing.Point(7, 20);
            this.rbDeleteUserTenant.Name = "rbDeleteUserTenant";
            this.rbDeleteUserTenant.Size = new System.Drawing.Size(86, 25);
            this.rbDeleteUserTenant.TabIndex = 3;
            this.rbDeleteUserTenant.TabStop = true;
            this.rbDeleteUserTenant.Text = "Student";
            this.rbDeleteUserTenant.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlAdmin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashbord | House Management System For AIUB Students";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabSearchUser.ResumeLayout(false);
            this.tabSearchUser.PerformLayout();
            this.gbLoginUserType.ResumeLayout(false);
            this.gbLoginUserType.PerformLayout();
            this.tabDeleteUser.ResumeLayout(false);
            this.tabDeleteUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabSearchUser;
        private System.Windows.Forms.TabPage tabDeleteUser;
        private System.Windows.Forms.Label lbSearchUserType;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.GroupBox gbLoginUserType;
        private System.Windows.Forms.RadioButton rbSearchUserRenter;
        private System.Windows.Forms.RadioButton rbSearchUserTenant;
        private System.Windows.Forms.Label errMsgSearchUserEmail;
        private System.Windows.Forms.TextBox tbSearchUserEmail;
        private System.Windows.Forms.Label lbSearchUserEmail;
        private System.Windows.Forms.Label errMsgDeleteUserEmail;
        private System.Windows.Forms.TextBox tbDeleteUserEmail;
        private System.Windows.Forms.Label lbDeleteUserEmail;
        private System.Windows.Forms.Label lbDeleteUserType;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeleteUserRenter;
        private System.Windows.Forms.RadioButton rbDeleteUserTenant;
        private System.Windows.Forms.GroupBox gbSearchUser;
        private System.Windows.Forms.Label errMsgSearchUser;
        private System.Windows.Forms.Label actionMsgDeleteUser;
    }
}