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
            this.lbUserType = new System.Windows.Forms.Label();
            this.errMsgPassword = new System.Windows.Forms.Label();
            this.errMsgEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbLoginType = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbRenter = new System.Windows.Forms.RadioButton();
            this.rbTenant = new System.Windows.Forms.RadioButton();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControlIndex.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.gbLoginType.SuspendLayout();
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
            this.tabLogin.Controls.Add(this.lbUserType);
            this.tabLogin.Controls.Add(this.errMsgPassword);
            this.tabLogin.Controls.Add(this.errMsgEmail);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.gbLoginType);
            this.tabLogin.Controls.Add(this.tbLoginPassword);
            this.tabLogin.Controls.Add(this.lbPassword);
            this.tabLogin.Controls.Add(this.tbLoginEmail);
            this.tabLogin.Controls.Add(this.lbEmail);
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(768, 523);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(65, 241);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(63, 17);
            this.lbUserType.TabIndex = 9;
            this.lbUserType.Text = "User Type";
            // 
            // errMsgPassword
            // 
            this.errMsgPassword.AutoSize = true;
            this.errMsgPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgPassword.Location = new System.Drawing.Point(192, 173);
            this.errMsgPassword.Name = "errMsgPassword";
            this.errMsgPassword.Size = new System.Drawing.Size(0, 15);
            this.errMsgPassword.TabIndex = 8;
            // 
            // errMsgEmail
            // 
            this.errMsgEmail.AutoSize = true;
            this.errMsgEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgEmail.Location = new System.Drawing.Point(192, 93);
            this.errMsgEmail.Name = "errMsgEmail";
            this.errMsgEmail.Size = new System.Drawing.Size(0, 15);
            this.errMsgEmail.TabIndex = 7;
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
            // gbLoginType
            // 
            this.gbLoginType.Controls.Add(this.rbAdmin);
            this.gbLoginType.Controls.Add(this.rbRenter);
            this.gbLoginType.Controls.Add(this.rbTenant);
            this.gbLoginType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbLoginType.Location = new System.Drawing.Point(196, 217);
            this.gbLoginType.Name = "gbLoginType";
            this.gbLoginType.Size = new System.Drawing.Size(445, 58);
            this.gbLoginType.TabIndex = 3;
            this.gbLoginType.TabStop = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(353, 20);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(62, 21);
            this.rbAdmin.TabIndex = 5;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbRenter
            // 
            this.rbRenter.AutoSize = true;
            this.rbRenter.Location = new System.Drawing.Point(179, 20);
            this.rbRenter.Name = "rbRenter";
            this.rbRenter.Size = new System.Drawing.Size(65, 21);
            this.rbRenter.TabIndex = 4;
            this.rbRenter.Text = "Renter";
            this.rbRenter.UseVisualStyleBackColor = true;
            // 
            // rbTenant
            // 
            this.rbTenant.AutoSize = true;
            this.rbTenant.Checked = true;
            this.rbTenant.Location = new System.Drawing.Point(7, 20);
            this.rbTenant.Name = "rbTenant";
            this.rbTenant.Size = new System.Drawing.Size(70, 21);
            this.rbTenant.TabIndex = 3;
            this.rbTenant.TabStop = true;
            this.rbTenant.Text = "Student";
            this.rbTenant.UseVisualStyleBackColor = true;
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
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(65, 149);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(196, 62);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(293, 24);
            this.tbLoginEmail.TabIndex = 1;
            this.tbLoginEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLoginEmail_KeyUp);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(65, 69);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 17);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // tabRegistration
            // 
            this.tabRegistration.Location = new System.Drawing.Point(4, 26);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(766, 515);
            this.tabRegistration.TabIndex = 1;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
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
            this.gbLoginType.ResumeLayout(false);
            this.gbLoginType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIndex;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbLoginType;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbRenter;
        private System.Windows.Forms.RadioButton rbTenant;
        private System.Windows.Forms.Label errMsgEmail;
        private System.Windows.Forms.Label errMsgPassword;
        private System.Windows.Forms.Label lbUserType;
    }
}