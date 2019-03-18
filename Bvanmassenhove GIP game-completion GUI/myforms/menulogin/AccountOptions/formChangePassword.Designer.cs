namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangePassword));
            this.btnClose = new System.Windows.Forms.Button();
            this.lvlChangePassword2 = new System.Windows.Forms.Label();
            this.txtChangePassword2 = new System.Windows.Forms.RichTextBox();
            this.lblChangePassword1 = new System.Windows.Forms.Label();
            this.txtChangePassword1 = new System.Windows.Forms.RichTextBox();
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
            this.btnClose.Location = new System.Drawing.Point(22, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvlChangePassword2
            // 
            this.lvlChangePassword2.AutoSize = true;
            this.lvlChangePassword2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlChangePassword2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvlChangePassword2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lvlChangePassword2.Location = new System.Drawing.Point(22, 81);
            this.lvlChangePassword2.Name = "lvlChangePassword2";
            this.lvlChangePassword2.Size = new System.Drawing.Size(193, 21);
            this.lvlChangePassword2.TabIndex = 29;
            this.lvlChangePassword2.Text = "repeat changed Password ";
            // 
            // txtChangePassword2
            // 
            this.txtChangePassword2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword2.Location = new System.Drawing.Point(22, 120);
            this.txtChangePassword2.Name = "txtChangePassword2";
            this.txtChangePassword2.Size = new System.Drawing.Size(241, 30);
            this.txtChangePassword2.TabIndex = 28;
            this.txtChangePassword2.Text = "";
            // 
            // lblChangePassword1
            // 
            this.lblChangePassword1.AutoSize = true;
            this.lblChangePassword1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChangePassword1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangePassword1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblChangePassword1.Location = new System.Drawing.Point(22, 10);
            this.lblChangePassword1.Name = "lblChangePassword1";
            this.lblChangePassword1.Size = new System.Drawing.Size(133, 21);
            this.lblChangePassword1.TabIndex = 27;
            this.lblChangePassword1.Text = "change Password";
            // 
            // txtChangePassword1
            // 
            this.txtChangePassword1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword1.Location = new System.Drawing.Point(22, 34);
            this.txtChangePassword1.Name = "txtChangePassword1";
            this.txtChangePassword1.Size = new System.Drawing.Size(241, 30);
            this.txtChangePassword1.TabIndex = 26;
            this.txtChangePassword1.Text = "";
            // 
            // formChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 265);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvlChangePassword2);
            this.Controls.Add(this.txtChangePassword2);
            this.Controls.Add(this.lblChangePassword1);
            this.Controls.Add(this.txtChangePassword1);
            this.Name = "formChangePassword";
            this.Text = "formChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lvlChangePassword2;
        private System.Windows.Forms.RichTextBox txtChangePassword2;
        private System.Windows.Forms.Label lblChangePassword1;
        private System.Windows.Forms.RichTextBox txtChangePassword1;
    }
}