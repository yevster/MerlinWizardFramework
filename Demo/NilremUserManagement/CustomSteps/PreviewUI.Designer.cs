namespace NilremUserManagement.CustomSteps
{
    partial class PreviewUI
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.chkEmbezzle = new System.Windows.Forms.CheckBox();
            this.chkEmployeeData = new System.Windows.Forms.CheckBox();
            this.chkConfidential = new System.Windows.Forms.CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.grpPermissions = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.grpPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.White;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picIcon.Location = new System.Drawing.Point(29, 18);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(107, 102);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblUserId
            // 
            this.lblUserId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(142, 31);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(286, 23);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControls.Controls.Add(this.grpPermissions);
            this.pnlControls.Controls.Add(this.lblEmail);
            this.pnlControls.Controls.Add(this.lblPassword);
            this.pnlControls.Controls.Add(this.lblRole);
            this.pnlControls.Controls.Add(this.lblFullName);
            this.pnlControls.Controls.Add(this.lblUserId);
            this.pnlControls.Controls.Add(this.picIcon);
            this.pnlControls.Location = new System.Drawing.Point(19, 19);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(428, 341);
            this.pnlControls.TabIndex = 2;
            // 
            // chkEmbezzle
            // 
            this.chkEmbezzle.AutoSize = true;
            this.chkEmbezzle.Enabled = false;
            this.chkEmbezzle.Location = new System.Drawing.Point(21, 71);
            this.chkEmbezzle.Name = "chkEmbezzle";
            this.chkEmbezzle.Size = new System.Drawing.Size(71, 17);
            this.chkEmbezzle.TabIndex = 4;
            this.chkEmbezzle.Text = "Embezzle";
            this.chkEmbezzle.UseVisualStyleBackColor = true;
            // 
            // chkEmployeeData
            // 
            this.chkEmployeeData.AutoSize = true;
            this.chkEmployeeData.Enabled = false;
            this.chkEmployeeData.Location = new System.Drawing.Point(21, 48);
            this.chkEmployeeData.Name = "chkEmployeeData";
            this.chkEmployeeData.Size = new System.Drawing.Size(136, 17);
            this.chkEmployeeData.TabIndex = 4;
            this.chkEmployeeData.Text = "Access Employee Data";
            this.chkEmployeeData.UseVisualStyleBackColor = true;
            // 
            // chkConfidential
            // 
            this.chkConfidential.AutoSize = true;
            this.chkConfidential.Enabled = false;
            this.chkConfidential.Location = new System.Drawing.Point(21, 25);
            this.chkConfidential.Name = "chkConfidential";
            this.chkConfidential.Size = new System.Drawing.Size(140, 17);
            this.chkConfidential.TabIndex = 4;
            this.chkConfidential.Text = "Access Confidential Info";
            this.chkConfidential.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(26, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(26, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(26, 148);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 16);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role: ";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(142, 67);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(286, 23);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPermissions
            // 
            this.grpPermissions.Controls.Add(this.chkConfidential);
            this.grpPermissions.Controls.Add(this.chkEmbezzle);
            this.grpPermissions.Controls.Add(this.chkEmployeeData);
            this.grpPermissions.Location = new System.Drawing.Point(126, 123);
            this.grpPermissions.Name = "grpPermissions";
            this.grpPermissions.Size = new System.Drawing.Size(185, 102);
            this.grpPermissions.TabIndex = 5;
            this.grpPermissions.TabStop = false;
            this.grpPermissions.Text = "&Permissions";
            // 
            // PreviewUI
            // 
            this.Controls.Add(this.pnlControls);
            this.Name = "PreviewUI";
            this.Size = new System.Drawing.Size(468, 383);
            this.Resize += new System.EventHandler(this.PreviewUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.grpPermissions.ResumeLayout(false);
            this.grpPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkConfidential;
        private System.Windows.Forms.CheckBox chkEmbezzle;
        private System.Windows.Forms.CheckBox chkEmployeeData;
        private System.Windows.Forms.GroupBox grpPermissions;
    }
}
