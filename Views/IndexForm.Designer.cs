namespace HousingManagementSystemForAIUBStudents.Views
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.tabControlIndex = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lbLoginUserType = new System.Windows.Forms.Label();
            this.errMsgLoginPassword = new System.Windows.Forms.Label();
            this.errMsgLoginEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbLoginUserType = new System.Windows.Forms.GroupBox();
            this.rbLoginAdmin = new System.Windows.Forms.RadioButton();
            this.rbLoginRenter = new System.Windows.Forms.RadioButton();
            this.rbLoginTenant = new System.Windows.Forms.RadioButton();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lbLoginPassword = new System.Windows.Forms.Label();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.lbLoginEmail = new System.Windows.Forms.Label();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.errMsgRegPhone = new System.Windows.Forms.Label();
            this.tbRegPhone = new System.Windows.Forms.TextBox();
            this.lbRegPhone = new System.Windows.Forms.Label();
            this.errMsgRegConfirmPassword = new System.Windows.Forms.Label();
            this.tbRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbRegConfirmPassword = new System.Windows.Forms.Label();
            this.errMsgRegName = new System.Windows.Forms.Label();
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.lbRegName = new System.Windows.Forms.Label();
            this.lbRegUserType = new System.Windows.Forms.Label();
            this.errMsgRegPassword = new System.Windows.Forms.Label();
            this.errMsgRegEmail = new System.Windows.Forms.Label();
            this.gbRegUserType = new System.Windows.Forms.GroupBox();
            this.rbRegRenter = new System.Windows.Forms.RadioButton();
            this.rbRegTenant = new System.Windows.Forms.RadioButton();
            this.tbRegPassword = new System.Windows.Forms.TextBox();
            this.lbRegPassword = new System.Windows.Forms.Label();
            this.tbRegEmail = new System.Windows.Forms.TextBox();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.tabControlIndex.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.gbLoginUserType.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.gbRegUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlIndex
            // 
            this.tabControlIndex.Controls.Add(this.tabLogin);
            this.tabControlIndex.Controls.Add(this.tabRegistration);
            this.tabControlIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlIndex.Location = new System.Drawing.Point(4, 4);
            this.tabControlIndex.Name = "tabControlIndex";
            this.tabControlIndex.SelectedIndex = 0;
            this.tabControlIndex.Size = new System.Drawing.Size(776, 553);
            this.tabControlIndex.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlIndex.TabIndex = 0;
            this.tabControlIndex.TabStop = false;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lbLoginUserType);
            this.tabLogin.Controls.Add(this.errMsgLoginPassword);
            this.tabLogin.Controls.Add(this.errMsgLoginEmail);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.gbLoginUserType);
            this.tabLogin.Controls.Add(this.tbLoginPassword);
            this.tabLogin.Controls.Add(this.lbLoginPassword);
            this.tabLogin.Controls.Add(this.tbLoginEmail);
            this.tabLogin.Controls.Add(this.lbLoginEmail);
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(768, 523);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lbLoginUserType
            // 
            this.lbLoginUserType.AutoSize = true;
            this.lbLoginUserType.Location = new System.Drawing.Point(65, 241);
            this.lbLoginUserType.Name = "lbLoginUserType";
            this.lbLoginUserType.Size = new System.Drawing.Size(63, 17);
            this.lbLoginUserType.TabIndex = 9;
            this.lbLoginUserType.Text = "User Type";
            // 
            // errMsgLoginPassword
            // 
            this.errMsgLoginPassword.AutoSize = true;
            this.errMsgLoginPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgLoginPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgLoginPassword.Location = new System.Drawing.Point(192, 173);
            this.errMsgLoginPassword.Name = "errMsgLoginPassword";
            this.errMsgLoginPassword.Size = new System.Drawing.Size(0, 15);
            this.errMsgLoginPassword.TabIndex = 8;
            // 
            // errMsgLoginEmail
            // 
            this.errMsgLoginEmail.AutoSize = true;
            this.errMsgLoginEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgLoginEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgLoginEmail.Location = new System.Drawing.Point(192, 93);
            this.errMsgLoginEmail.Name = "errMsgLoginEmail";
            this.errMsgLoginEmail.Size = new System.Drawing.Size(0, 15);
            this.errMsgLoginEmail.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(196, 328);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbLoginUserType
            // 
            this.gbLoginUserType.Controls.Add(this.rbLoginAdmin);
            this.gbLoginUserType.Controls.Add(this.rbLoginRenter);
            this.gbLoginUserType.Controls.Add(this.rbLoginTenant);
            this.gbLoginUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbLoginUserType.Location = new System.Drawing.Point(196, 217);
            this.gbLoginUserType.Name = "gbLoginUserType";
            this.gbLoginUserType.Size = new System.Drawing.Size(445, 58);
            this.gbLoginUserType.TabIndex = 3;
            this.gbLoginUserType.TabStop = false;
            // 
            // rbLoginAdmin
            // 
            this.rbLoginAdmin.AutoSize = true;
            this.rbLoginAdmin.Location = new System.Drawing.Point(353, 20);
            this.rbLoginAdmin.Name = "rbLoginAdmin";
            this.rbLoginAdmin.Size = new System.Drawing.Size(62, 21);
            this.rbLoginAdmin.TabIndex = 5;
            this.rbLoginAdmin.Text = "Admin";
            this.rbLoginAdmin.UseVisualStyleBackColor = true;
            // 
            // rbLoginRenter
            // 
            this.rbLoginRenter.AutoSize = true;
            this.rbLoginRenter.Location = new System.Drawing.Point(179, 20);
            this.rbLoginRenter.Name = "rbLoginRenter";
            this.rbLoginRenter.Size = new System.Drawing.Size(65, 21);
            this.rbLoginRenter.TabIndex = 4;
            this.rbLoginRenter.Text = "Renter";
            this.rbLoginRenter.UseVisualStyleBackColor = true;
            // 
            // rbLoginTenant
            // 
            this.rbLoginTenant.AutoSize = true;
            this.rbLoginTenant.Checked = true;
            this.rbLoginTenant.Location = new System.Drawing.Point(7, 20);
            this.rbLoginTenant.Name = "rbLoginTenant";
            this.rbLoginTenant.Size = new System.Drawing.Size(70, 21);
            this.rbLoginTenant.TabIndex = 3;
            this.rbLoginTenant.TabStop = true;
            this.rbLoginTenant.Text = "Student";
            this.rbLoginTenant.UseVisualStyleBackColor = true;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(196, 142);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(293, 24);
            this.tbLoginPassword.TabIndex = 2;
            this.tbLoginPassword.UseSystemPasswordChar = true;
            this.tbLoginPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLoginPassword_KeyUp);
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.AutoSize = true;
            this.lbLoginPassword.Location = new System.Drawing.Point(65, 149);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(61, 17);
            this.lbLoginPassword.TabIndex = 2;
            this.lbLoginPassword.Text = "Password";
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(196, 62);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(293, 24);
            this.tbLoginEmail.TabIndex = 1;
            this.tbLoginEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLoginEmail_KeyUp);
            // 
            // lbLoginEmail
            // 
            this.lbLoginEmail.AutoSize = true;
            this.lbLoginEmail.Location = new System.Drawing.Point(65, 69);
            this.lbLoginEmail.Name = "lbLoginEmail";
            this.lbLoginEmail.Size = new System.Drawing.Size(39, 17);
            this.lbLoginEmail.TabIndex = 0;
            this.lbLoginEmail.Text = "Email";
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.btnRegistration);
            this.tabRegistration.Controls.Add(this.errMsgRegPhone);
            this.tabRegistration.Controls.Add(this.tbRegPhone);
            this.tabRegistration.Controls.Add(this.lbRegPhone);
            this.tabRegistration.Controls.Add(this.errMsgRegConfirmPassword);
            this.tabRegistration.Controls.Add(this.tbRegConfirmPassword);
            this.tabRegistration.Controls.Add(this.lbRegConfirmPassword);
            this.tabRegistration.Controls.Add(this.errMsgRegName);
            this.tabRegistration.Controls.Add(this.tbRegName);
            this.tabRegistration.Controls.Add(this.lbRegName);
            this.tabRegistration.Controls.Add(this.lbRegUserType);
            this.tabRegistration.Controls.Add(this.errMsgRegPassword);
            this.tabRegistration.Controls.Add(this.errMsgRegEmail);
            this.tabRegistration.Controls.Add(this.gbRegUserType);
            this.tabRegistration.Controls.Add(this.tbRegPassword);
            this.tabRegistration.Controls.Add(this.lbRegPassword);
            this.tabRegistration.Controls.Add(this.tbRegEmail);
            this.tabRegistration.Controls.Add(this.lbRegEmail);
            this.tabRegistration.Location = new System.Drawing.Point(4, 26);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(768, 523);
            this.tabRegistration.TabIndex = 1;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Enabled = false;
            this.btnRegistration.Location = new System.Drawing.Point(214, 452);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(150, 35);
            this.btnRegistration.TabIndex = 27;
            this.btnRegistration.Text = "Register";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // errMsgRegPhone
            // 
            this.errMsgRegPhone.AutoSize = true;
            this.errMsgRegPhone.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRegPhone.ForeColor = System.Drawing.Color.Red;
            this.errMsgRegPhone.Location = new System.Drawing.Point(210, 188);
            this.errMsgRegPhone.Name = "errMsgRegPhone";
            this.errMsgRegPhone.Size = new System.Drawing.Size(0, 15);
            this.errMsgRegPhone.TabIndex = 26;
            // 
            // tbRegPhone
            // 
            this.tbRegPhone.Location = new System.Drawing.Point(214, 157);
            this.tbRegPhone.Name = "tbRegPhone";
            this.tbRegPhone.Size = new System.Drawing.Size(293, 24);
            this.tbRegPhone.TabIndex = 3;
            this.tbRegPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegPhone_KeyUp);
            // 
            // lbRegPhone
            // 
            this.lbRegPhone.AutoSize = true;
            this.lbRegPhone.Location = new System.Drawing.Point(36, 164);
            this.lbRegPhone.Name = "lbRegPhone";
            this.lbRegPhone.Size = new System.Drawing.Size(43, 17);
            this.lbRegPhone.TabIndex = 24;
            this.lbRegPhone.Text = "Phone";
            // 
            // errMsgRegConfirmPassword
            // 
            this.errMsgRegConfirmPassword.AutoSize = true;
            this.errMsgRegConfirmPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRegConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgRegConfirmPassword.Location = new System.Drawing.Point(210, 331);
            this.errMsgRegConfirmPassword.Name = "errMsgRegConfirmPassword";
            this.errMsgRegConfirmPassword.Size = new System.Drawing.Size(0, 15);
            this.errMsgRegConfirmPassword.TabIndex = 23;
            // 
            // tbRegConfirmPassword
            // 
            this.tbRegConfirmPassword.Location = new System.Drawing.Point(214, 300);
            this.tbRegConfirmPassword.Name = "tbRegConfirmPassword";
            this.tbRegConfirmPassword.Size = new System.Drawing.Size(293, 24);
            this.tbRegConfirmPassword.TabIndex = 5;
            this.tbRegConfirmPassword.UseSystemPasswordChar = true;
            this.tbRegConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegConfirmPassword_KeyUp);
            // 
            // lbRegConfirmPassword
            // 
            this.lbRegConfirmPassword.AutoSize = true;
            this.lbRegConfirmPassword.Location = new System.Drawing.Point(36, 307);
            this.lbRegConfirmPassword.Name = "lbRegConfirmPassword";
            this.lbRegConfirmPassword.Size = new System.Drawing.Size(108, 17);
            this.lbRegConfirmPassword.TabIndex = 22;
            this.lbRegConfirmPassword.Text = "Confirm Password";
            // 
            // errMsgRegName
            // 
            this.errMsgRegName.AutoSize = true;
            this.errMsgRegName.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRegName.ForeColor = System.Drawing.Color.Red;
            this.errMsgRegName.Location = new System.Drawing.Point(210, 48);
            this.errMsgRegName.Name = "errMsgRegName";
            this.errMsgRegName.Size = new System.Drawing.Size(0, 15);
            this.errMsgRegName.TabIndex = 20;
            // 
            // tbRegName
            // 
            this.tbRegName.Location = new System.Drawing.Point(214, 17);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(293, 24);
            this.tbRegName.TabIndex = 1;
            this.tbRegName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegName_KeyUp);
            // 
            // lbRegName
            // 
            this.lbRegName.AutoSize = true;
            this.lbRegName.Location = new System.Drawing.Point(36, 24);
            this.lbRegName.Name = "lbRegName";
            this.lbRegName.Size = new System.Drawing.Size(42, 17);
            this.lbRegName.TabIndex = 18;
            this.lbRegName.Text = "Name";
            // 
            // lbRegUserType
            // 
            this.lbRegUserType.AutoSize = true;
            this.lbRegUserType.Location = new System.Drawing.Point(35, 395);
            this.lbRegUserType.Name = "lbRegUserType";
            this.lbRegUserType.Size = new System.Drawing.Size(63, 17);
            this.lbRegUserType.TabIndex = 17;
            this.lbRegUserType.Text = "User Type";
            // 
            // errMsgRegPassword
            // 
            this.errMsgRegPassword.AutoSize = true;
            this.errMsgRegPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRegPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgRegPassword.Location = new System.Drawing.Point(210, 260);
            this.errMsgRegPassword.Name = "errMsgRegPassword";
            this.errMsgRegPassword.Size = new System.Drawing.Size(0, 15);
            this.errMsgRegPassword.TabIndex = 16;
            // 
            // errMsgRegEmail
            // 
            this.errMsgRegEmail.AutoSize = true;
            this.errMsgRegEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRegEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgRegEmail.Location = new System.Drawing.Point(210, 118);
            this.errMsgRegEmail.Name = "errMsgRegEmail";
            this.errMsgRegEmail.Size = new System.Drawing.Size(0, 15);
            this.errMsgRegEmail.TabIndex = 15;
            // 
            // gbRegUserType
            // 
            this.gbRegUserType.Controls.Add(this.rbRegRenter);
            this.gbRegUserType.Controls.Add(this.rbRegTenant);
            this.gbRegUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbRegUserType.Location = new System.Drawing.Point(214, 371);
            this.gbRegUserType.Name = "gbRegUserType";
            this.gbRegUserType.Size = new System.Drawing.Size(293, 58);
            this.gbRegUserType.TabIndex = 14;
            this.gbRegUserType.TabStop = false;
            // 
            // rbRegRenter
            // 
            this.rbRegRenter.AutoSize = true;
            this.rbRegRenter.Location = new System.Drawing.Point(179, 20);
            this.rbRegRenter.Name = "rbRegRenter";
            this.rbRegRenter.Size = new System.Drawing.Size(65, 21);
            this.rbRegRenter.TabIndex = 7;
            this.rbRegRenter.Text = "Renter";
            this.rbRegRenter.UseVisualStyleBackColor = true;
            // 
            // rbRegTenant
            // 
            this.rbRegTenant.AutoSize = true;
            this.rbRegTenant.Checked = true;
            this.rbRegTenant.Location = new System.Drawing.Point(7, 20);
            this.rbRegTenant.Name = "rbRegTenant";
            this.rbRegTenant.Size = new System.Drawing.Size(70, 21);
            this.rbRegTenant.TabIndex = 6;
            this.rbRegTenant.TabStop = true;
            this.rbRegTenant.Text = "Student";
            this.rbRegTenant.UseVisualStyleBackColor = true;
            // 
            // tbRegPassword
            // 
            this.tbRegPassword.Location = new System.Drawing.Point(214, 229);
            this.tbRegPassword.Name = "tbRegPassword";
            this.tbRegPassword.Size = new System.Drawing.Size(293, 24);
            this.tbRegPassword.TabIndex = 4;
            this.tbRegPassword.UseSystemPasswordChar = true;
            this.tbRegPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegPassword_KeyUp);
            // 
            // lbRegPassword
            // 
            this.lbRegPassword.AutoSize = true;
            this.lbRegPassword.Location = new System.Drawing.Point(36, 236);
            this.lbRegPassword.Name = "lbRegPassword";
            this.lbRegPassword.Size = new System.Drawing.Size(61, 17);
            this.lbRegPassword.TabIndex = 13;
            this.lbRegPassword.Text = "Password";
            // 
            // tbRegEmail
            // 
            this.tbRegEmail.Location = new System.Drawing.Point(214, 87);
            this.tbRegEmail.Name = "tbRegEmail";
            this.tbRegEmail.Size = new System.Drawing.Size(293, 24);
            this.tbRegEmail.TabIndex = 2;
            this.tbRegEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegEmail_KeyUp);
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Location = new System.Drawing.Point(36, 94);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(39, 17);
            this.lbRegEmail.TabIndex = 10;
            this.lbRegEmail.Text = "Email";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlIndex);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "IndexForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Management System For AIUB Students";
            this.tabControlIndex.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.gbLoginUserType.ResumeLayout(false);
            this.gbLoginUserType.PerformLayout();
            this.tabRegistration.ResumeLayout(false);
            this.tabRegistration.PerformLayout();
            this.gbRegUserType.ResumeLayout(false);
            this.gbRegUserType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIndex;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.Label lbLoginEmail;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbLoginUserType;
        private System.Windows.Forms.RadioButton rbLoginRenter;
        private System.Windows.Forms.RadioButton rbLoginTenant;
        private System.Windows.Forms.Label errMsgLoginEmail;
        private System.Windows.Forms.Label errMsgLoginPassword;
        private System.Windows.Forms.Label lbLoginUserType;
        private System.Windows.Forms.Label errMsgRegConfirmPassword;
        private System.Windows.Forms.TextBox tbRegConfirmPassword;
        private System.Windows.Forms.Label lbRegConfirmPassword;
        private System.Windows.Forms.Label errMsgRegName;
        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.Label lbRegName;
        private System.Windows.Forms.Label lbRegUserType;
        private System.Windows.Forms.Label errMsgRegPassword;
        private System.Windows.Forms.Label errMsgRegEmail;
        private System.Windows.Forms.GroupBox gbRegUserType;
        private System.Windows.Forms.RadioButton rbRegRenter;
        private System.Windows.Forms.RadioButton rbRegTenant;
        private System.Windows.Forms.TextBox tbRegPassword;
        private System.Windows.Forms.Label lbRegPassword;
        private System.Windows.Forms.TextBox tbRegEmail;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Label errMsgRegPhone;
        private System.Windows.Forms.TextBox tbRegPhone;
        private System.Windows.Forms.Label lbRegPhone;
        private System.Windows.Forms.RadioButton rbLoginAdmin;
        private System.Windows.Forms.Button btnRegistration;
    }
}