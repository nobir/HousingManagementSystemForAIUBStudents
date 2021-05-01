namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    partial class RenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenterForm));
            this.tabViewHouse = new System.Windows.Forms.TabPage();
            this.tabControlRenter = new System.Windows.Forms.TabControl();
            this.tabEditProfile = new System.Windows.Forms.TabPage();
            this.tabAddHouse = new System.Windows.Forms.TabPage();
            this.tabDeleteHouse = new System.Windows.Forms.TabPage();
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
            this.dgvViewHouse = new System.Windows.Forms.DataGridView();
            this.errMsgAddHouseSector = new System.Windows.Forms.Label();
            this.tbAddHouseSector = new System.Windows.Forms.TextBox();
            this.lbAddHouseSector = new System.Windows.Forms.Label();
            this.errMsgAddHouseName = new System.Windows.Forms.Label();
            this.tbAddHouseName = new System.Windows.Forms.TextBox();
            this.lbAddHouseName = new System.Windows.Forms.Label();
            this.errMsgAddHouseNumber = new System.Windows.Forms.Label();
            this.tbRenterAddNumber = new System.Windows.Forms.TextBox();
            this.lbAddHouseNumber = new System.Windows.Forms.Label();
            this.errMsgAddHousePrize = new System.Windows.Forms.Label();
            this.tbAddHousePrize = new System.Windows.Forms.TextBox();
            this.lbAddHousePrize = new System.Windows.Forms.Label();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.actionMsgDeleteHouse = new System.Windows.Forms.Label();
            this.errMsgDeleteHouseId = new System.Windows.Forms.Label();
            this.tbDeleteHouseId = new System.Windows.Forms.TextBox();
            this.lbDeleteHouseId = new System.Windows.Forms.Label();
            this.btnDeleteHouse = new System.Windows.Forms.Button();
            this.actionMsgViewHouse = new System.Windows.Forms.Label();
            this.errMsgViewHouseId = new System.Windows.Forms.Label();
            this.tbViewHouseId = new System.Windows.Forms.TextBox();
            this.lbViewHouseId = new System.Windows.Forms.Label();
            this.btnViewHouse = new System.Windows.Forms.Button();
            this.tabViewHouse.SuspendLayout();
            this.tabControlRenter.SuspendLayout();
            this.tabEditProfile.SuspendLayout();
            this.tabAddHouse.SuspendLayout();
            this.tabDeleteHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHouse)).BeginInit();
            this.SuspendLayout();
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
            // tabControlRenter
            // 
            this.tabControlRenter.Controls.Add(this.tabEditProfile);
            this.tabControlRenter.Controls.Add(this.tabViewHouse);
            this.tabControlRenter.Controls.Add(this.tabAddHouse);
            this.tabControlRenter.Controls.Add(this.tabDeleteHouse);
            this.tabControlRenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRenter.Location = new System.Drawing.Point(4, 4);
            this.tabControlRenter.Name = "tabControlRenter";
            this.tabControlRenter.SelectedIndex = 0;
            this.tabControlRenter.Size = new System.Drawing.Size(774, 545);
            this.tabControlRenter.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlRenter.TabIndex = 0;
            this.tabControlRenter.TabStop = false;
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
            // tabAddHouse
            // 
            this.tabAddHouse.Controls.Add(this.btnAddHouse);
            this.tabAddHouse.Controls.Add(this.errMsgAddHousePrize);
            this.tabAddHouse.Controls.Add(this.tbAddHousePrize);
            this.tabAddHouse.Controls.Add(this.lbAddHousePrize);
            this.tabAddHouse.Controls.Add(this.errMsgAddHouseSector);
            this.tabAddHouse.Controls.Add(this.tbAddHouseSector);
            this.tabAddHouse.Controls.Add(this.lbAddHouseSector);
            this.tabAddHouse.Controls.Add(this.errMsgAddHouseName);
            this.tabAddHouse.Controls.Add(this.tbAddHouseName);
            this.tabAddHouse.Controls.Add(this.lbAddHouseName);
            this.tabAddHouse.Controls.Add(this.errMsgAddHouseNumber);
            this.tabAddHouse.Controls.Add(this.tbRenterAddNumber);
            this.tabAddHouse.Controls.Add(this.lbAddHouseNumber);
            this.tabAddHouse.Location = new System.Drawing.Point(4, 30);
            this.tabAddHouse.Name = "tabAddHouse";
            this.tabAddHouse.Size = new System.Drawing.Size(766, 511);
            this.tabAddHouse.TabIndex = 2;
            this.tabAddHouse.Text = "Add House";
            this.tabAddHouse.UseVisualStyleBackColor = true;
            // 
            // tabDeleteHouse
            // 
            this.tabDeleteHouse.Controls.Add(this.actionMsgDeleteHouse);
            this.tabDeleteHouse.Controls.Add(this.errMsgDeleteHouseId);
            this.tabDeleteHouse.Controls.Add(this.tbDeleteHouseId);
            this.tabDeleteHouse.Controls.Add(this.lbDeleteHouseId);
            this.tabDeleteHouse.Controls.Add(this.btnDeleteHouse);
            this.tabDeleteHouse.Location = new System.Drawing.Point(4, 30);
            this.tabDeleteHouse.Name = "tabDeleteHouse";
            this.tabDeleteHouse.Size = new System.Drawing.Size(766, 511);
            this.tabDeleteHouse.TabIndex = 3;
            this.tabDeleteHouse.Text = "Delete House";
            this.tabDeleteHouse.UseVisualStyleBackColor = true;
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
            // errMsgAddHouseSector
            // 
            this.errMsgAddHouseSector.AutoSize = true;
            this.errMsgAddHouseSector.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAddHouseSector.ForeColor = System.Drawing.Color.Red;
            this.errMsgAddHouseSector.Location = new System.Drawing.Point(210, 196);
            this.errMsgAddHouseSector.Name = "errMsgAddHouseSector";
            this.errMsgAddHouseSector.Size = new System.Drawing.Size(0, 19);
            this.errMsgAddHouseSector.TabIndex = 35;
            // 
            // tbAddHouseSector
            // 
            this.tbAddHouseSector.Location = new System.Drawing.Point(214, 165);
            this.tbAddHouseSector.Name = "tbAddHouseSector";
            this.tbAddHouseSector.Size = new System.Drawing.Size(293, 28);
            this.tbAddHouseSector.TabIndex = 3;
            // 
            // lbAddHouseSector
            // 
            this.lbAddHouseSector.AutoSize = true;
            this.lbAddHouseSector.Location = new System.Drawing.Point(36, 172);
            this.lbAddHouseSector.Name = "lbAddHouseSector";
            this.lbAddHouseSector.Size = new System.Drawing.Size(102, 21);
            this.lbAddHouseSector.TabIndex = 34;
            this.lbAddHouseSector.Text = "House Sector";
            // 
            // errMsgAddHouseName
            // 
            this.errMsgAddHouseName.AutoSize = true;
            this.errMsgAddHouseName.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAddHouseName.ForeColor = System.Drawing.Color.Red;
            this.errMsgAddHouseName.Location = new System.Drawing.Point(210, 56);
            this.errMsgAddHouseName.Name = "errMsgAddHouseName";
            this.errMsgAddHouseName.Size = new System.Drawing.Size(0, 19);
            this.errMsgAddHouseName.TabIndex = 33;
            // 
            // tbAddHouseName
            // 
            this.tbAddHouseName.Location = new System.Drawing.Point(214, 25);
            this.tbAddHouseName.Name = "tbAddHouseName";
            this.tbAddHouseName.Size = new System.Drawing.Size(293, 28);
            this.tbAddHouseName.TabIndex = 1;
            // 
            // lbAddHouseName
            // 
            this.lbAddHouseName.AutoSize = true;
            this.lbAddHouseName.Location = new System.Drawing.Point(36, 32);
            this.lbAddHouseName.Name = "lbAddHouseName";
            this.lbAddHouseName.Size = new System.Drawing.Size(99, 21);
            this.lbAddHouseName.TabIndex = 32;
            this.lbAddHouseName.Text = "House Name";
            // 
            // errMsgAddHouseNumber
            // 
            this.errMsgAddHouseNumber.AutoSize = true;
            this.errMsgAddHouseNumber.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAddHouseNumber.ForeColor = System.Drawing.Color.Red;
            this.errMsgAddHouseNumber.Location = new System.Drawing.Point(210, 126);
            this.errMsgAddHouseNumber.Name = "errMsgAddHouseNumber";
            this.errMsgAddHouseNumber.Size = new System.Drawing.Size(0, 19);
            this.errMsgAddHouseNumber.TabIndex = 31;
            // 
            // tbRenterAddNumber
            // 
            this.tbRenterAddNumber.Location = new System.Drawing.Point(214, 95);
            this.tbRenterAddNumber.Name = "tbRenterAddNumber";
            this.tbRenterAddNumber.Size = new System.Drawing.Size(293, 28);
            this.tbRenterAddNumber.TabIndex = 2;
            // 
            // lbAddHouseNumber
            // 
            this.lbAddHouseNumber.AutoSize = true;
            this.lbAddHouseNumber.Location = new System.Drawing.Point(36, 102);
            this.lbAddHouseNumber.Name = "lbAddHouseNumber";
            this.lbAddHouseNumber.Size = new System.Drawing.Size(115, 21);
            this.lbAddHouseNumber.TabIndex = 30;
            this.lbAddHouseNumber.Text = "House Numebr";
            // 
            // errMsgAddHousePrize
            // 
            this.errMsgAddHousePrize.AutoSize = true;
            this.errMsgAddHousePrize.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAddHousePrize.ForeColor = System.Drawing.Color.Red;
            this.errMsgAddHousePrize.Location = new System.Drawing.Point(210, 274);
            this.errMsgAddHousePrize.Name = "errMsgAddHousePrize";
            this.errMsgAddHousePrize.Size = new System.Drawing.Size(0, 19);
            this.errMsgAddHousePrize.TabIndex = 38;
            // 
            // tbAddHousePrize
            // 
            this.tbAddHousePrize.Location = new System.Drawing.Point(214, 243);
            this.tbAddHousePrize.Name = "tbAddHousePrize";
            this.tbAddHousePrize.Size = new System.Drawing.Size(293, 28);
            this.tbAddHousePrize.TabIndex = 4;
            // 
            // lbAddHousePrize
            // 
            this.lbAddHousePrize.AutoSize = true;
            this.lbAddHousePrize.Location = new System.Drawing.Point(36, 250);
            this.lbAddHousePrize.Name = "lbAddHousePrize";
            this.lbAddHousePrize.Size = new System.Drawing.Size(92, 21);
            this.lbAddHousePrize.TabIndex = 37;
            this.lbAddHousePrize.Text = "House Prize";
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Enabled = false;
            this.btnAddHouse.Location = new System.Drawing.Point(214, 345);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(150, 35);
            this.btnAddHouse.TabIndex = 5;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            // 
            // actionMsgDeleteHouse
            // 
            this.actionMsgDeleteHouse.AutoSize = true;
            this.actionMsgDeleteHouse.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgDeleteHouse.ForeColor = System.Drawing.Color.Red;
            this.actionMsgDeleteHouse.Location = new System.Drawing.Point(225, 137);
            this.actionMsgDeleteHouse.Name = "actionMsgDeleteHouse";
            this.actionMsgDeleteHouse.Size = new System.Drawing.Size(209, 29);
            this.actionMsgDeleteHouse.TabIndex = 29;
            this.actionMsgDeleteHouse.Text = "House Not Found!!!";
            this.actionMsgDeleteHouse.Visible = false;
            // 
            // errMsgDeleteHouseId
            // 
            this.errMsgDeleteHouseId.AutoSize = true;
            this.errMsgDeleteHouseId.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgDeleteHouseId.ForeColor = System.Drawing.Color.Red;
            this.errMsgDeleteHouseId.Location = new System.Drawing.Point(165, 62);
            this.errMsgDeleteHouseId.Name = "errMsgDeleteHouseId";
            this.errMsgDeleteHouseId.Size = new System.Drawing.Size(0, 19);
            this.errMsgDeleteHouseId.TabIndex = 28;
            // 
            // tbDeleteHouseId
            // 
            this.tbDeleteHouseId.Location = new System.Drawing.Point(169, 31);
            this.tbDeleteHouseId.Name = "tbDeleteHouseId";
            this.tbDeleteHouseId.Size = new System.Drawing.Size(293, 28);
            this.tbDeleteHouseId.TabIndex = 23;
            // 
            // lbDeleteHouseId
            // 
            this.lbDeleteHouseId.AutoSize = true;
            this.lbDeleteHouseId.Location = new System.Drawing.Point(38, 38);
            this.lbDeleteHouseId.Name = "lbDeleteHouseId";
            this.lbDeleteHouseId.Size = new System.Drawing.Size(72, 21);
            this.lbDeleteHouseId.TabIndex = 27;
            this.lbDeleteHouseId.Text = "House ID";
            // 
            // btnDeleteHouse
            // 
            this.btnDeleteHouse.Enabled = false;
            this.btnDeleteHouse.Location = new System.Drawing.Point(554, 24);
            this.btnDeleteHouse.Name = "btnDeleteHouse";
            this.btnDeleteHouse.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteHouse.TabIndex = 25;
            this.btnDeleteHouse.Text = "Delete";
            this.btnDeleteHouse.UseVisualStyleBackColor = true;
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
            // 
            // RenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlRenter);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RenterForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renter Dashbord | House Management System For AIUB Students";
            this.tabViewHouse.ResumeLayout(false);
            this.tabViewHouse.PerformLayout();
            this.tabControlRenter.ResumeLayout(false);
            this.tabEditProfile.ResumeLayout(false);
            this.tabEditProfile.PerformLayout();
            this.tabAddHouse.ResumeLayout(false);
            this.tabAddHouse.PerformLayout();
            this.tabDeleteHouse.ResumeLayout(false);
            this.tabDeleteHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabViewHouse;
        private System.Windows.Forms.TabControl tabControlRenter;
        private System.Windows.Forms.TabPage tabEditProfile;
        private System.Windows.Forms.TabPage tabAddHouse;
        private System.Windows.Forms.TabPage tabDeleteHouse;
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
        private System.Windows.Forms.DataGridView dgvViewHouse;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Label errMsgAddHousePrize;
        private System.Windows.Forms.TextBox tbAddHousePrize;
        private System.Windows.Forms.Label lbAddHousePrize;
        private System.Windows.Forms.Label errMsgAddHouseSector;
        private System.Windows.Forms.TextBox tbAddHouseSector;
        private System.Windows.Forms.Label lbAddHouseSector;
        private System.Windows.Forms.Label errMsgAddHouseName;
        private System.Windows.Forms.TextBox tbAddHouseName;
        private System.Windows.Forms.Label lbAddHouseName;
        private System.Windows.Forms.Label errMsgAddHouseNumber;
        private System.Windows.Forms.TextBox tbRenterAddNumber;
        private System.Windows.Forms.Label lbAddHouseNumber;
        private System.Windows.Forms.Label actionMsgDeleteHouse;
        private System.Windows.Forms.Label errMsgDeleteHouseId;
        private System.Windows.Forms.TextBox tbDeleteHouseId;
        private System.Windows.Forms.Label lbDeleteHouseId;
        private System.Windows.Forms.Button btnDeleteHouse;
        private System.Windows.Forms.Label actionMsgViewHouse;
        private System.Windows.Forms.Label errMsgViewHouseId;
        private System.Windows.Forms.TextBox tbViewHouseId;
        private System.Windows.Forms.Label lbViewHouseId;
        private System.Windows.Forms.Button btnViewHouse;
    }
}