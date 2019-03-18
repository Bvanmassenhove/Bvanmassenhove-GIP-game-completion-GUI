namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formAccountOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAccountOptions));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(12, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangePassword.FlatAppearance.BorderSize = 3;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(12, 60);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(241, 42);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.White;
            this.btnChangeUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUsername.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeUsername.FlatAppearance.BorderSize = 3;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsername.ForeColor = System.Drawing.Color.Black;
            this.btnChangeUsername.Location = new System.Drawing.Point(12, 12);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(241, 42);
            this.btnChangeUsername.TabIndex = 3;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 3;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Location = new System.Drawing.Point(12, 108);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(241, 42);
            this.btnDeleteAccount.TabIndex = 6;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // formAccountOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 269);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeUsername);
            this.Name = "formAccountOptions";
            this.Text = "formAccountOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}