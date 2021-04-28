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
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControlIndex.SuspendLayout();
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
            this.tabControlIndex.Size = new System.Drawing.Size(774, 545);
            this.tabControlIndex.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlIndex.TabIndex = 0;
            this.tabControlIndex.TabStop = false;
            // 
            // tabLogin
            // 
            this.tabLogin.Location = new System.Drawing.Point(4, 30);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(766, 511);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabRegistration
            // 
            this.tabRegistration.Location = new System.Drawing.Point(4, 30);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(766, 511);
            this.tabRegistration.TabIndex = 1;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlIndex);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIndex;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegistration;
    }
}