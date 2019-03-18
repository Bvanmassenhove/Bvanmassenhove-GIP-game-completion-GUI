namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formChangeName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangeName));
            this.lblChangeName1 = new System.Windows.Forms.Label();
            this.txtChangeName1 = new System.Windows.Forms.RichTextBox();
            this.lblChangeName2 = new System.Windows.Forms.Label();
            this.txtChangeName2 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeName1
            // 
            this.lblChangeName1.AutoSize = true;
            this.lblChangeName1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChangeName1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangeName1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblChangeName1.Location = new System.Drawing.Point(12, 9);
            this.lblChangeName1.Name = "lblChangeName1";
            this.lblChangeName1.Size = new System.Drawing.Size(109, 21);
            this.lblChangeName1.TabIndex = 22;
            this.lblChangeName1.Text = "change Name ";
            // 
            // txtChangeName1
            // 
            this.txtChangeName1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeName1.Location = new System.Drawing.Point(12, 33);
            this.txtChangeName1.Name = "txtChangeName1";
            this.txtChangeName1.Size = new System.Drawing.Size(241, 30);
            this.txtChangeName1.TabIndex = 21;
            this.txtChangeName1.Text = "";
            // 
            // lblChangeName2
            // 
            this.lblChangeName2.AutoSize = true;
            this.lblChangeName2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChangeName2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangeName2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblChangeName2.Location = new System.Drawing.Point(12, 80);
            this.lblChangeName2.Name = "lblChangeName2";
            this.lblChangeName2.Size = new System.Drawing.Size(165, 21);
            this.lblChangeName2.TabIndex = 24;
            this.lblChangeName2.Text = "repeat changed Name ";
            // 
            // txtChangeName2
            // 
            this.txtChangeName2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeName2.Location = new System.Drawing.Point(12, 119);
            this.txtChangeName2.Name = "txtChangeName2";
            this.txtChangeName2.Size = new System.Drawing.Size(241, 30);
            this.txtChangeName2.TabIndex = 23;
            this.txtChangeName2.Text = "";
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
            this.btnClose.Location = new System.Drawing.Point(12, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblChangeName2);
            this.Controls.Add(this.txtChangeName2);
            this.Controls.Add(this.lblChangeName1);
            this.Controls.Add(this.txtChangeName1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "formChangeName";
            this.Text = "formChangeName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeName1;
        private System.Windows.Forms.RichTextBox txtChangeName1;
        private System.Windows.Forms.Label lblChangeName2;
        private System.Windows.Forms.RichTextBox txtChangeName2;
        private System.Windows.Forms.Button btnClose;
    }
}