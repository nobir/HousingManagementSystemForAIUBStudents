namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    partial class TenantForm
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
            this.tabControlTenant = new System.Windows.Forms.TabControl();
            this.tabTenantEditProfile = new System.Windows.Forms.TabPage();
            this.btnTenantEditProfile = new System.Windows.Forms.Button();
            this.errMsgTenantEditPhone = new System.Windows.Forms.Label();
            this.tbTenantEditPhone = new System.Windows.Forms.TextBox();
            this.lbTenantEditPhone = new System.Windows.Forms.Label();
            this.errMsgTenantEditName = new System.Windows.Forms.Label();
            this.tbTenantEditName = new System.Windows.Forms.TextBox();
            this.lbTenantEditName = new System.Windows.Forms.Label();
            this.errMsgTenantEditEmail = new System.Windows.Forms.Label();
            this.tbTenantEditEmail = new System.Windows.Forms.TextBox();
            this.lbTenantEditEmail = new System.Windows.Forms.Label();
            this.tabTenantViewHouse = new System.Windows.Forms.TabPage();
            this.actionMsgTenantViewHouse = new System.Windows.Forms.Label();
            this.errMsgTenantViewHouseId = new System.Windows.Forms.Label();
            this.tbTenantViewHouseId = new System.Windows.Forms.TextBox();
            this.lbTenantViewHouseId = new System.Windows.Forms.Label();
            this.btnTenantViewHouse = new System.Windows.Forms.Button();
            this.dgvTenantViewHouse = new System.Windows.Forms.DataGridView();
            this.tabTenantRentHouse = new System.Windows.Forms.TabPage();
            this.actionMsgTenantRentHouse = new System.Windows.Forms.Label();
            this.errMsgTenantRentHouseId = new System.Windows.Forms.Label();
            this.tbTenantRentHouseId = new System.Windows.Forms.TextBox();
            this.lbTenantRentHouseId = new System.Windows.Forms.Label();
            this.btnTenantRentHouse = new System.Windows.Forms.Button();
            this.tabControlTenant.SuspendLayout();
            this.tabTenantEditProfile.SuspendLayout();
            this.tabTenantViewHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantViewHouse)).BeginInit();
            this.tabTenantRentHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTenant
            // 
            this.tabControlTenant.Controls.Add(this.tabTenantEditProfile);
            this.tabControlTenant.Controls.Add(this.tabTenantViewHouse);
            this.tabControlTenant.Controls.Add(this.tabTenantRentHouse);
            this.tabControlTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTenant.Location = new System.Drawing.Point(4, 4);
            this.tabControlTenant.Name = "tabControlTenant";
            this.tabControlTenant.SelectedIndex = 0;
            this.tabControlTenant.Size = new System.Drawing.Size(774, 545);
            this.tabControlTenant.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlTenant.TabIndex = 1;
            this.tabControlTenant.TabStop = false;
            // 
            // tabTenantEditProfile
            // 
            this.tabTenantEditProfile.Controls.Add(this.btnTenantEditProfile);
            this.tabTenantEditProfile.Controls.Add(this.errMsgTenantEditPhone);
            this.tabTenantEditProfile.Controls.Add(this.tbTenantEditPhone);
            this.tabTenantEditProfile.Controls.Add(this.lbTenantEditPhone);
            this.tabTenantEditProfile.Controls.Add(this.errMsgTenantEditName);
            this.tabTenantEditProfile.Controls.Add(this.tbTenantEditName);
            this.tabTenantEditProfile.Controls.Add(this.lbTenantEditName);
            this.tabTenantEditProfile.Controls.Add(this.errMsgTenantEditEmail);
            this.tabTenantEditProfile.Controls.Add(this.tbTenantEditEmail);
            this.tabTenantEditProfile.Controls.Add(this.lbTenantEditEmail);
            this.tabTenantEditProfile.Location = new System.Drawing.Point(4, 30);
            this.tabTenantEditProfile.Name = "tabTenantEditProfile";
            this.tabTenantEditProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenantEditProfile.Size = new System.Drawing.Size(766, 511);
            this.tabTenantEditProfile.TabIndex = 0;
            this.tabTenantEditProfile.Text = "Edit Profile";
            this.tabTenantEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnTenantEditProfile
            // 
            this.btnTenantEditProfile.Enabled = false;
            this.btnTenantEditProfile.Location = new System.Drawing.Point(214, 262);
            this.btnTenantEditProfile.Name = "btnTenantEditProfile";
            this.btnTenantEditProfile.Size = new System.Drawing.Size(150, 35);
            this.btnTenantEditProfile.TabIndex = 4;
            this.btnTenantEditProfile.Text = "Edit";
            this.btnTenantEditProfile.UseVisualStyleBackColor = true;
            this.btnTenantEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // errMsgTenantEditPhone
            // 
            this.errMsgTenantEditPhone.AutoSize = true;
            this.errMsgTenantEditPhone.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgTenantEditPhone.ForeColor = System.Drawing.Color.Red;
            this.errMsgTenantEditPhone.Location = new System.Drawing.Point(210, 196);
            this.errMsgTenantEditPhone.Name = "errMsgTenantEditPhone";
            this.errMsgTenantEditPhone.Size = new System.Drawing.Size(0, 19);
            this.errMsgTenantEditPhone.TabIndex = 44;
            // 
            // tbTenantEditPhone
            // 
            this.tbTenantEditPhone.Location = new System.Drawing.Point(214, 165);
            this.tbTenantEditPhone.Name = "tbTenantEditPhone";
            this.tbTenantEditPhone.Size = new System.Drawing.Size(293, 28);
            this.tbTenantEditPhone.TabIndex = 3;
            this.tbTenantEditPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditPhone_KeyUp);
            // 
            // lbTenantEditPhone
            // 
            this.lbTenantEditPhone.AutoSize = true;
            this.lbTenantEditPhone.Location = new System.Drawing.Point(36, 172);
            this.lbTenantEditPhone.Name = "lbTenantEditPhone";
            this.lbTenantEditPhone.Size = new System.Drawing.Size(54, 21);
            this.lbTenantEditPhone.TabIndex = 43;
            this.lbTenantEditPhone.Text = "Phone";
            // 
            // errMsgTenantEditName
            // 
            this.errMsgTenantEditName.AutoSize = true;
            this.errMsgTenantEditName.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgTenantEditName.ForeColor = System.Drawing.Color.Red;
            this.errMsgTenantEditName.Location = new System.Drawing.Point(210, 56);
            this.errMsgTenantEditName.Name = "errMsgTenantEditName";
            this.errMsgTenantEditName.Size = new System.Drawing.Size(0, 19);
            this.errMsgTenantEditName.TabIndex = 40;
            // 
            // tbTenantEditName
            // 
            this.tbTenantEditName.Location = new System.Drawing.Point(214, 25);
            this.tbTenantEditName.Name = "tbTenantEditName";
            this.tbTenantEditName.Size = new System.Drawing.Size(293, 28);
            this.tbTenantEditName.TabIndex = 1;
            this.tbTenantEditName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditName_KeyUp);
            // 
            // lbTenantEditName
            // 
            this.lbTenantEditName.AutoSize = true;
            this.lbTenantEditName.Location = new System.Drawing.Point(36, 32);
            this.lbTenantEditName.Name = "lbTenantEditName";
            this.lbTenantEditName.Size = new System.Drawing.Size(51, 21);
            this.lbTenantEditName.TabIndex = 39;
            this.lbTenantEditName.Text = "Name";
            // 
            // errMsgTenantEditEmail
            // 
            this.errMsgTenantEditEmail.AutoSize = true;
            this.errMsgTenantEditEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgTenantEditEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgTenantEditEmail.Location = new System.Drawing.Point(210, 126);
            this.errMsgTenantEditEmail.Name = "errMsgTenantEditEmail";
            this.errMsgTenantEditEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgTenantEditEmail.TabIndex = 36;
            // 
            // tbTenantEditEmail
            // 
            this.tbTenantEditEmail.Location = new System.Drawing.Point(214, 95);
            this.tbTenantEditEmail.Name = "tbTenantEditEmail";
            this.tbTenantEditEmail.Size = new System.Drawing.Size(293, 28);
            this.tbTenantEditEmail.TabIndex = 2;
            this.tbTenantEditEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditEmail_KeyUp);
            // 
            // lbTenantEditEmail
            // 
            this.lbTenantEditEmail.AutoSize = true;
            this.lbTenantEditEmail.Location = new System.Drawing.Point(36, 102);
            this.lbTenantEditEmail.Name = "lbTenantEditEmail";
            this.lbTenantEditEmail.Size = new System.Drawing.Size(48, 21);
            this.lbTenantEditEmail.TabIndex = 33;
            this.lbTenantEditEmail.Text = "Email";
            // 
            // tabTenantViewHouse
            // 
            this.tabTenantViewHouse.Controls.Add(this.actionMsgTenantViewHouse);
            this.tabTenantViewHouse.Controls.Add(this.errMsgTenantViewHouseId);
            this.tabTenantViewHouse.Controls.Add(this.tbTenantViewHouseId);
            this.tabTenantViewHouse.Controls.Add(this.lbTenantViewHouseId);
            this.tabTenantViewHouse.Controls.Add(this.btnTenantViewHouse);
            this.tabTenantViewHouse.Controls.Add(this.dgvTenantViewHouse);
            this.tabTenantViewHouse.Location = new System.Drawing.Point(4, 30);
            this.tabTenantViewHouse.Name = "tabTenantViewHouse";
            this.tabTenantViewHouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenantViewHouse.Size = new System.Drawing.Size(766, 511);
            this.tabTenantViewHouse.TabIndex = 1;
            this.tabTenantViewHouse.Text = "View House";
            this.tabTenantViewHouse.UseVisualStyleBackColor = true;
            // 
            // actionMsgTenantViewHouse
            // 
            this.actionMsgTenantViewHouse.AutoSize = true;
            this.actionMsgTenantViewHouse.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgTenantViewHouse.ForeColor = System.Drawing.Color.Red;
            this.actionMsgTenantViewHouse.Location = new System.Drawing.Point(225, 137);
            this.actionMsgTenantViewHouse.Name = "actionMsgTenantViewHouse";
            this.actionMsgTenantViewHouse.Size = new System.Drawing.Size(209, 29);
            this.actionMsgTenantViewHouse.TabIndex = 34;
            this.actionMsgTenantViewHouse.Text = "House Not Found!!!";
            this.actionMsgTenantViewHouse.Visible = false;
            // 
            // errMsgTenantViewHouseId
            // 
            this.errMsgTenantViewHouseId.AutoSize = true;
            this.errMsgTenantViewHouseId.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgTenantViewHouseId.ForeColor = System.Drawing.Color.Red;
            this.errMsgTenantViewHouseId.Location = new System.Drawing.Point(165, 62);
            this.errMsgTenantViewHouseId.Name = "errMsgTenantViewHouseId";
            this.errMsgTenantViewHouseId.Size = new System.Drawing.Size(0, 19);
            this.errMsgTenantViewHouseId.TabIndex = 33;
            // 
            // tbTenantViewHouseId
            // 
            this.tbTenantViewHouseId.Location = new System.Drawing.Point(169, 31);
            this.tbTenantViewHouseId.Name = "tbTenantViewHouseId";
            this.tbTenantViewHouseId.Size = new System.Drawing.Size(293, 28);
            this.tbTenantViewHouseId.TabIndex = 30;
            this.tbTenantViewHouseId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbViewHouseId_KeyUp);
            // 
            // lbTenantViewHouseId
            // 
            this.lbTenantViewHouseId.AutoSize = true;
            this.lbTenantViewHouseId.Location = new System.Drawing.Point(38, 38);
            this.lbTenantViewHouseId.Name = "lbTenantViewHouseId";
            this.lbTenantViewHouseId.Size = new System.Drawing.Size(72, 21);
            this.lbTenantViewHouseId.TabIndex = 32;
            this.lbTenantViewHouseId.Text = "House ID";
            // 
            // btnTenantViewHouse
            // 
            this.btnTenantViewHouse.Enabled = false;
            this.btnTenantViewHouse.Location = new System.Drawing.Point(554, 24);
            this.btnTenantViewHouse.Name = "btnTenantViewHouse";
            this.btnTenantViewHouse.Size = new System.Drawing.Size(150, 35);
            this.btnTenantViewHouse.TabIndex = 31;
            this.btnTenantViewHouse.Text = "Search";
            this.btnTenantViewHouse.UseVisualStyleBackColor = true;
            this.btnTenantViewHouse.Click += new System.EventHandler(this.btnViewHouse_Click);
            // 
            // dgvTenantViewHouse
            // 
            this.dgvTenantViewHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenantViewHouse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTenantViewHouse.Location = new System.Drawing.Point(3, 242);
            this.dgvTenantViewHouse.Name = "dgvTenantViewHouse";
            this.dgvTenantViewHouse.RowTemplate.Height = 24;
            this.dgvTenantViewHouse.Size = new System.Drawing.Size(760, 266);
            this.dgvTenantViewHouse.TabIndex = 0;
            // 
            // tabTenantRentHouse
            // 
            this.tabTenantRentHouse.Controls.Add(this.actionMsgTenantRentHouse);
            this.tabTenantRentHouse.Controls.Add(this.errMsgTenantRentHouseId);
            this.tabTenantRentHouse.Controls.Add(this.tbTenantRentHouseId);
            this.tabTenantRentHouse.Controls.Add(this.lbTenantRentHouseId);
            this.tabTenantRentHouse.Controls.Add(this.btnTenantRentHouse);
            this.tabTenantRentHouse.Location = new System.Drawing.Point(4, 30);
            this.tabTenantRentHouse.Name = "tabTenantRentHouse";
            this.tabTenantRentHouse.Size = new System.Drawing.Size(766, 511);
            this.tabTenantRentHouse.TabIndex = 3;
            this.tabTenantRentHouse.Text = "Rent House";
            this.tabTenantRentHouse.UseVisualStyleBackColor = true;
            // 
            // actionMsgTenantRentHouse
            // 
            this.actionMsgTenantRentHouse.AutoSize = true;
            this.actionMsgTenantRentHouse.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgTenantRentHouse.ForeColor = System.Drawing.Color.Red;
            this.actionMsgTenantRentHouse.Location = new System.Drawing.Point(225, 137);
            this.actionMsgTenantRentHouse.Name = "actionMsgTenantRentHouse";
            this.actionMsgTenantRentHouse.Size = new System.Drawing.Size(209, 29);
            this.actionMsgTenantRentHouse.TabIndex = 29;
            this.actionMsgTenantRentHouse.Text = "House Not Found!!!";
            this.actionMsgTenantRentHouse.Visible = false;
            // 
            // errMsgTenantRentHouseId
            // 
            this.errMsgTenantRentHouseId.AutoSize = true;
            this.errMsgTenantRentHouseId.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgTenantRentHouseId.ForeColor = System.Drawing.Color.Red;
            this.errMsgTenantRentHouseId.Location = new System.Drawing.Point(165, 62);
            this.errMsgTenantRentHouseId.Name = "errMsgTenantRentHouseId";
            this.errMsgTenantRentHouseId.Size = new System.Drawing.Size(0, 19);
            this.errMsgTenantRentHouseId.TabIndex = 28;
            // 
            // tbTenantRentHouseId
            // 
            this.tbTenantRentHouseId.Location = new System.Drawing.Point(169, 31);
            this.tbTenantRentHouseId.Name = "tbTenantRentHouseId";
            this.tbTenantRentHouseId.Size = new System.Drawing.Size(293, 28);
            this.tbTenantRentHouseId.TabIndex = 23;
            this.tbTenantRentHouseId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRentHouseId_KeyUp);
            // 
            // lbTenantRentHouseId
            // 
            this.lbTenantRentHouseId.AutoSize = true;
            this.lbTenantRentHouseId.Location = new System.Drawing.Point(38, 38);
            this.lbTenantRentHouseId.Name = "lbTenantRentHouseId";
            this.lbTenantRentHouseId.Size = new System.Drawing.Size(72, 21);
            this.lbTenantRentHouseId.TabIndex = 27;
            this.lbTenantRentHouseId.Text = "House ID";
            // 
            // btnTenantRentHouse
            // 
            this.btnTenantRentHouse.Enabled = false;
            this.btnTenantRentHouse.Location = new System.Drawing.Point(554, 24);
            this.btnTenantRentHouse.Name = "btnTenantRentHouse";
            this.btnTenantRentHouse.Size = new System.Drawing.Size(150, 35);
            this.btnTenantRentHouse.TabIndex = 25;
            this.btnTenantRentHouse.Text = "Rent";
            this.btnTenantRentHouse.UseVisualStyleBackColor = true;
            this.btnTenantRentHouse.Click += new System.EventHandler(this.btnRentHouse_Click);
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlTenant);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TenantForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant Dashbord | House Management System For AIUB Students";
            this.tabControlTenant.ResumeLayout(false);
            this.tabTenantEditProfile.ResumeLayout(false);
            this.tabTenantEditProfile.PerformLayout();
            this.tabTenantViewHouse.ResumeLayout(false);
            this.tabTenantViewHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantViewHouse)).EndInit();
            this.tabTenantRentHouse.ResumeLayout(false);
            this.tabTenantRentHouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTenant;
        private System.Windows.Forms.TabPage tabTenantEditProfile;
        private System.Windows.Forms.Button btnTenantEditProfile;
        private System.Windows.Forms.Label errMsgTenantEditPhone;
        private System.Windows.Forms.TextBox tbTenantEditPhone;
        private System.Windows.Forms.Label lbTenantEditPhone;
        private System.Windows.Forms.Label errMsgTenantEditName;
        private System.Windows.Forms.TextBox tbTenantEditName;
        private System.Windows.Forms.Label lbTenantEditName;
        private System.Windows.Forms.Label errMsgTenantEditEmail;
        private System.Windows.Forms.TextBox tbTenantEditEmail;
        private System.Windows.Forms.Label lbTenantEditEmail;
        private System.Windows.Forms.TabPage tabTenantViewHouse;
        private System.Windows.Forms.Label actionMsgTenantViewHouse;
        private System.Windows.Forms.Label errMsgTenantViewHouseId;
        private System.Windows.Forms.TextBox tbTenantViewHouseId;
        private System.Windows.Forms.Label lbTenantViewHouseId;
        private System.Windows.Forms.Button btnTenantViewHouse;
        private System.Windows.Forms.DataGridView dgvTenantViewHouse;
        private System.Windows.Forms.TabPage tabTenantRentHouse;
        private System.Windows.Forms.Label actionMsgTenantRentHouse;
        private System.Windows.Forms.Label errMsgTenantRentHouseId;
        private System.Windows.Forms.TextBox tbTenantRentHouseId;
        private System.Windows.Forms.Label lbTenantRentHouseId;
        private System.Windows.Forms.Button btnTenantRentHouse;

    }
}