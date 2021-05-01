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
            this.tabEditProfile = new System.Windows.Forms.TabPage();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.errMsgEditPhone = new System.Windows.Forms.Label();
            this.tbEditPhone = new System.Windows.Forms.TextBox();
            this.lbEditPhone = new System.Windows.Forms.Label();
            this.errMsgEditName = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.lbEditName = new System.Windows.Forms.Label();
            this.errMsgEditEmail = new System.Windows.Forms.Label();
            this.tbEditEmail = new System.Windows.Forms.TextBox();
            this.lbEditEmail = new System.Windows.Forms.Label();
            this.tabViewHouse = new System.Windows.Forms.TabPage();
            this.actionMsgViewHouse = new System.Windows.Forms.Label();
            this.errMsgViewHouseId = new System.Windows.Forms.Label();
            this.tbViewHouseId = new System.Windows.Forms.TextBox();
            this.lbViewHouseId = new System.Windows.Forms.Label();
            this.btnViewHouse = new System.Windows.Forms.Button();
            this.dgvViewHouse = new System.Windows.Forms.DataGridView();
            this.tabRentHouse = new System.Windows.Forms.TabPage();
            this.actionMsgRentHouse = new System.Windows.Forms.Label();
            this.errMsgRentHouseId = new System.Windows.Forms.Label();
            this.tbRentHouseId = new System.Windows.Forms.TextBox();
            this.lbRentHouseId = new System.Windows.Forms.Label();
            this.btnRentHouse = new System.Windows.Forms.Button();
            this.tabControlTenant.SuspendLayout();
            this.tabEditProfile.SuspendLayout();
            this.tabViewHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHouse)).BeginInit();
            this.tabRentHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTenant
            // 
            this.tabControlTenant.Controls.Add(this.tabEditProfile);
            this.tabControlTenant.Controls.Add(this.tabViewHouse);
            this.tabControlTenant.Controls.Add(this.tabRentHouse);
            this.tabControlTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTenant.Location = new System.Drawing.Point(4, 4);
            this.tabControlTenant.Name = "tabControlTenant";
            this.tabControlTenant.SelectedIndex = 0;
            this.tabControlTenant.Size = new System.Drawing.Size(774, 545);
            this.tabControlTenant.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlTenant.TabIndex = 1;
            this.tabControlTenant.TabStop = false;
            // 
            // tabEditProfile
            // 
            this.tabEditProfile.Controls.Add(this.btnEditProfile);
            this.tabEditProfile.Controls.Add(this.errMsgEditPhone);
            this.tabEditProfile.Controls.Add(this.tbEditPhone);
            this.tabEditProfile.Controls.Add(this.lbEditPhone);
            this.tabEditProfile.Controls.Add(this.errMsgEditName);
            this.tabEditProfile.Controls.Add(this.tbEditName);
            this.tabEditProfile.Controls.Add(this.lbEditName);
            this.tabEditProfile.Controls.Add(this.errMsgEditEmail);
            this.tabEditProfile.Controls.Add(this.tbEditEmail);
            this.tabEditProfile.Controls.Add(this.lbEditEmail);
            this.tabEditProfile.Location = new System.Drawing.Point(4, 30);
            this.tabEditProfile.Name = "tabEditProfile";
            this.tabEditProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditProfile.Size = new System.Drawing.Size(766, 511);
            this.tabEditProfile.TabIndex = 0;
            this.tabEditProfile.Text = "Edit Profile";
            this.tabEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Enabled = false;
            this.btnEditProfile.Location = new System.Drawing.Point(214, 262);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(150, 35);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // errMsgEditPhone
            // 
            this.errMsgEditPhone.AutoSize = true;
            this.errMsgEditPhone.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgEditPhone.ForeColor = System.Drawing.Color.Red;
            this.errMsgEditPhone.Location = new System.Drawing.Point(210, 196);
            this.errMsgEditPhone.Name = "errMsgEditPhone";
            this.errMsgEditPhone.Size = new System.Drawing.Size(0, 19);
            this.errMsgEditPhone.TabIndex = 44;
            // 
            // tbEditPhone
            // 
            this.tbEditPhone.Location = new System.Drawing.Point(214, 165);
            this.tbEditPhone.Name = "tbEditPhone";
            this.tbEditPhone.Size = new System.Drawing.Size(293, 28);
            this.tbEditPhone.TabIndex = 3;
            this.tbEditPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditPhone_KeyUp);
            // 
            // lbEditPhone
            // 
            this.lbEditPhone.AutoSize = true;
            this.lbEditPhone.Location = new System.Drawing.Point(36, 172);
            this.lbEditPhone.Name = "lbEditPhone";
            this.lbEditPhone.Size = new System.Drawing.Size(54, 21);
            this.lbEditPhone.TabIndex = 43;
            this.lbEditPhone.Text = "Phone";
            // 
            // errMsgEditName
            // 
            this.errMsgEditName.AutoSize = true;
            this.errMsgEditName.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgEditName.ForeColor = System.Drawing.Color.Red;
            this.errMsgEditName.Location = new System.Drawing.Point(210, 56);
            this.errMsgEditName.Name = "errMsgEditName";
            this.errMsgEditName.Size = new System.Drawing.Size(0, 19);
            this.errMsgEditName.TabIndex = 40;
            // 
            // tbEditName
            // 
            this.tbEditName.Location = new System.Drawing.Point(214, 25);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(293, 28);
            this.tbEditName.TabIndex = 1;
            this.tbEditName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditName_KeyUp);
            // 
            // lbEditName
            // 
            this.lbEditName.AutoSize = true;
            this.lbEditName.Location = new System.Drawing.Point(36, 32);
            this.lbEditName.Name = "lbEditName";
            this.lbEditName.Size = new System.Drawing.Size(51, 21);
            this.lbEditName.TabIndex = 39;
            this.lbEditName.Text = "Name";
            // 
            // errMsgEditEmail
            // 
            this.errMsgEditEmail.AutoSize = true;
            this.errMsgEditEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgEditEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgEditEmail.Location = new System.Drawing.Point(210, 126);
            this.errMsgEditEmail.Name = "errMsgEditEmail";
            this.errMsgEditEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgEditEmail.TabIndex = 36;
            // 
            // tbEditEmail
            // 
            this.tbEditEmail.Location = new System.Drawing.Point(214, 95);
            this.tbEditEmail.Name = "tbEditEmail";
            this.tbEditEmail.Size = new System.Drawing.Size(293, 28);
            this.tbEditEmail.TabIndex = 2;
            this.tbEditEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEditEmail_KeyUp);
            // 
            // lbEditEmail
            // 
            this.lbEditEmail.AutoSize = true;
            this.lbEditEmail.Location = new System.Drawing.Point(36, 102);
            this.lbEditEmail.Name = "lbEditEmail";
            this.lbEditEmail.Size = new System.Drawing.Size(48, 21);
            this.lbEditEmail.TabIndex = 33;
            this.lbEditEmail.Text = "Email";
            // 
            // tabViewHouse
            // 
            this.tabViewHouse.Controls.Add(this.actionMsgViewHouse);
            this.tabViewHouse.Controls.Add(this.errMsgViewHouseId);
            this.tabViewHouse.Controls.Add(this.tbViewHouseId);
            this.tabViewHouse.Controls.Add(this.lbViewHouseId);
            this.tabViewHouse.Controls.Add(this.btnViewHouse);
            this.tabViewHouse.Controls.Add(this.dgvViewHouse);
            this.tabViewHouse.Location = new System.Drawing.Point(4, 30);
            this.tabViewHouse.Name = "tabViewHouse";
            this.tabViewHouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewHouse.Size = new System.Drawing.Size(766, 511);
            this.tabViewHouse.TabIndex = 1;
            this.tabViewHouse.Text = "View House";
            this.tabViewHouse.UseVisualStyleBackColor = true;
            // 
            // actionMsgViewHouse
            // 
            this.actionMsgViewHouse.AutoSize = true;
            this.actionMsgViewHouse.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgViewHouse.ForeColor = System.Drawing.Color.Red;
            this.actionMsgViewHouse.Location = new System.Drawing.Point(225, 137);
            this.actionMsgViewHouse.Name = "actionMsgViewHouse";
            this.actionMsgViewHouse.Size = new System.Drawing.Size(209, 29);
            this.actionMsgViewHouse.TabIndex = 34;
            this.actionMsgViewHouse.Text = "House Not Found!!!";
            this.actionMsgViewHouse.Visible = false;
            // 
            // errMsgViewHouseId
            // 
            this.errMsgViewHouseId.AutoSize = true;
            this.errMsgViewHouseId.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgViewHouseId.ForeColor = System.Drawing.Color.Red;
            this.errMsgViewHouseId.Location = new System.Drawing.Point(165, 62);
            this.errMsgViewHouseId.Name = "errMsgViewHouseId";
            this.errMsgViewHouseId.Size = new System.Drawing.Size(0, 19);
            this.errMsgViewHouseId.TabIndex = 33;
            // 
            // tbViewHouseId
            // 
            this.tbViewHouseId.Location = new System.Drawing.Point(169, 31);
            this.tbViewHouseId.Name = "tbViewHouseId";
            this.tbViewHouseId.Size = new System.Drawing.Size(293, 28);
            this.tbViewHouseId.TabIndex = 30;
            this.tbViewHouseId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbViewHouseId_KeyUp);
            // 
            // lbViewHouseId
            // 
            this.lbViewHouseId.AutoSize = true;
            this.lbViewHouseId.Location = new System.Drawing.Point(38, 38);
            this.lbViewHouseId.Name = "lbViewHouseId";
            this.lbViewHouseId.Size = new System.Drawing.Size(72, 21);
            this.lbViewHouseId.TabIndex = 32;
            this.lbViewHouseId.Text = "House ID";
            // 
            // btnViewHouse
            // 
            this.btnViewHouse.Enabled = false;
            this.btnViewHouse.Location = new System.Drawing.Point(554, 24);
            this.btnViewHouse.Name = "btnViewHouse";
            this.btnViewHouse.Size = new System.Drawing.Size(150, 35);
            this.btnViewHouse.TabIndex = 31;
            this.btnViewHouse.Text = "Search";
            this.btnViewHouse.UseVisualStyleBackColor = true;
            this.btnViewHouse.Click += new System.EventHandler(this.btnViewHouse_Click);
            // 
            // dgvViewHouse
            // 
            this.dgvViewHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewHouse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvViewHouse.Location = new System.Drawing.Point(3, 242);
            this.dgvViewHouse.Name = "dgvViewHouse";
            this.dgvViewHouse.RowTemplate.Height = 24;
            this.dgvViewHouse.Size = new System.Drawing.Size(760, 266);
            this.dgvViewHouse.TabIndex = 0;
            // 
            // tabRentHouse
            // 
            this.tabRentHouse.Controls.Add(this.actionMsgRentHouse);
            this.tabRentHouse.Controls.Add(this.errMsgRentHouseId);
            this.tabRentHouse.Controls.Add(this.tbRentHouseId);
            this.tabRentHouse.Controls.Add(this.lbRentHouseId);
            this.tabRentHouse.Controls.Add(this.btnRentHouse);
            this.tabRentHouse.Location = new System.Drawing.Point(4, 30);
            this.tabRentHouse.Name = "tabRentHouse";
            this.tabRentHouse.Size = new System.Drawing.Size(766, 511);
            this.tabRentHouse.TabIndex = 3;
            this.tabRentHouse.Text = "Rent House";
            this.tabRentHouse.UseVisualStyleBackColor = true;
            // 
            // actionMsgRentHouse
            // 
            this.actionMsgRentHouse.AutoSize = true;
            this.actionMsgRentHouse.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgRentHouse.ForeColor = System.Drawing.Color.Red;
            this.actionMsgRentHouse.Location = new System.Drawing.Point(225, 137);
            this.actionMsgRentHouse.Name = "actionMsgRentHouse";
            this.actionMsgRentHouse.Size = new System.Drawing.Size(209, 29);
            this.actionMsgRentHouse.TabIndex = 29;
            this.actionMsgRentHouse.Text = "House Not Found!!!";
            this.actionMsgRentHouse.Visible = false;
            // 
            // errMsgRentHouseId
            // 
            this.errMsgRentHouseId.AutoSize = true;
            this.errMsgRentHouseId.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgRentHouseId.ForeColor = System.Drawing.Color.Red;
            this.errMsgRentHouseId.Location = new System.Drawing.Point(165, 62);
            this.errMsgRentHouseId.Name = "errMsgRentHouseId";
            this.errMsgRentHouseId.Size = new System.Drawing.Size(0, 19);
            this.errMsgRentHouseId.TabIndex = 28;
            // 
            // tbRentHouseId
            // 
            this.tbRentHouseId.Location = new System.Drawing.Point(169, 31);
            this.tbRentHouseId.Name = "tbRentHouseId";
            this.tbRentHouseId.Size = new System.Drawing.Size(293, 28);
            this.tbRentHouseId.TabIndex = 23;
            this.tbRentHouseId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRentHouseId_KeyUp);
            // 
            // lbRentHouseId
            // 
            this.lbRentHouseId.AutoSize = true;
            this.lbRentHouseId.Location = new System.Drawing.Point(38, 38);
            this.lbRentHouseId.Name = "lbRentHouseId";
            this.lbRentHouseId.Size = new System.Drawing.Size(72, 21);
            this.lbRentHouseId.TabIndex = 27;
            this.lbRentHouseId.Text = "House ID";
            // 
            // btnRentHouse
            // 
            this.btnRentHouse.Enabled = false;
            this.btnRentHouse.Location = new System.Drawing.Point(554, 24);
            this.btnRentHouse.Name = "btnRentHouse";
            this.btnRentHouse.Size = new System.Drawing.Size(150, 35);
            this.btnRentHouse.TabIndex = 25;
            this.btnRentHouse.Text = "Rent";
            this.btnRentHouse.UseVisualStyleBackColor = true;
            this.btnRentHouse.Click += new System.EventHandler(this.btnRentHouse_Click);
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
            this.tabEditProfile.ResumeLayout(false);
            this.tabEditProfile.PerformLayout();
            this.tabViewHouse.ResumeLayout(false);
            this.tabViewHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHouse)).EndInit();
            this.tabRentHouse.ResumeLayout(false);
            this.tabRentHouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTenant;
        private System.Windows.Forms.TabPage tabEditProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label errMsgEditPhone;
        private System.Windows.Forms.TextBox tbEditPhone;
        private System.Windows.Forms.Label lbEditPhone;
        private System.Windows.Forms.Label errMsgEditName;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label lbEditName;
        private System.Windows.Forms.Label errMsgEditEmail;
        private System.Windows.Forms.TextBox tbEditEmail;
        private System.Windows.Forms.Label lbEditEmail;
        private System.Windows.Forms.TabPage tabViewHouse;
        private System.Windows.Forms.Label actionMsgViewHouse;
        private System.Windows.Forms.Label errMsgViewHouseId;
        private System.Windows.Forms.TextBox tbViewHouseId;
        private System.Windows.Forms.Label lbViewHouseId;
        private System.Windows.Forms.Button btnViewHouse;
        private System.Windows.Forms.DataGridView dgvViewHouse;
        private System.Windows.Forms.TabPage tabRentHouse;
        private System.Windows.Forms.Label actionMsgRentHouse;
        private System.Windows.Forms.Label errMsgRentHouseId;
        private System.Windows.Forms.TextBox tbRentHouseId;
        private System.Windows.Forms.Label lbRentHouseId;
        private System.Windows.Forms.Button btnRentHouse;

    }
}