namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formShowGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formShowGames));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGameList1 = new System.Windows.Forms.Label();
            this.lblProcentList1 = new System.Windows.Forms.Label();
            this.lblGameList2 = new System.Windows.Forms.Label();
            this.lblProcentList2 = new System.Windows.Forms.Label();
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
            this.btnClose.Location = new System.Drawing.Point(12, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 45);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGameList1
            // 
            this.lblGameList1.AutoSize = true;
            this.lblGameList1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameList1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameList1.Location = new System.Drawing.Point(12, 13);
            this.lblGameList1.Name = "lblGameList1";
            this.lblGameList1.Size = new System.Drawing.Size(94, 16);
            this.lblGameList1.TabIndex = 15;
            this.lblGameList1.Text = "PLACEHOLDER";
            // 
            // lblProcentList1
            // 
            this.lblProcentList1.AutoSize = true;
            this.lblProcentList1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcentList1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.lblProcentList1.Location = new System.Drawing.Point(243, 13);
            this.lblProcentList1.Name = "lblProcentList1";
            this.lblProcentList1.Size = new System.Drawing.Size(94, 16);
            this.lblProcentList1.TabIndex = 16;
            this.lblProcentList1.Text = "PLACEHOLDER";
            // 
            // lblGameList2
            // 
            this.lblGameList2.AutoSize = true;
            this.lblGameList2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameList2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.lblGameList2.Location = new System.Drawing.Point(477, 13);
            this.lblGameList2.Name = "lblGameList2";
            this.lblGameList2.Size = new System.Drawing.Size(94, 16);
            this.lblGameList2.TabIndex = 17;
            this.lblGameList2.Text = "PLACEHOLDER";
            // 
            // lblProcentList2
            // 
            this.lblProcentList2.AutoSize = true;
            this.lblProcentList2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcentList2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.lblProcentList2.Location = new System.Drawing.Point(711, 13);
            this.lblProcentList2.Name = "lblProcentList2";
            this.lblProcentList2.Size = new System.Drawing.Size(94, 16);
            this.lblProcentList2.TabIndex = 18;
            this.lblProcentList2.Text = "PLACEHOLDER";
            // 
            // formShowGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 541);
            this.Controls.Add(this.lblProcentList2);
            this.Controls.Add(this.lblGameList2);
            this.Controls.Add(this.lblProcentList1);
            this.Controls.Add(this.lblGameList1);
            this.Controls.Add(this.btnClose);
            this.Name = "formShowGames";
            this.Text = "formShowGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGameList1;
        private System.Windows.Forms.Label lblProcentList1;
        private System.Windows.Forms.Label lblGameList2;
        private System.Windows.Forms.Label lblProcentList2;
    }
}