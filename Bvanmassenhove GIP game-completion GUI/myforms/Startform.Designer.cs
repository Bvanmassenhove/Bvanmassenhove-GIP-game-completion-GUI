namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class Startform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startform));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(241, 42);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.White;
            this.btnNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAccount.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnNewAccount.FlatAppearance.BorderSize = 3;
            this.btnNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccount.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnNewAccount.Location = new System.Drawing.Point(12, 60);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(241, 42);
            this.btnNewAccount.TabIndex = 8;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // Startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 269);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewAccount);
            this.Name = "Startform";
            this.Text = "Startform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewAccount;
    }
}