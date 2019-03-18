namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formAddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddGame));
            this.lblProcentCompletion = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.txtProcentCompletion = new System.Windows.Forms.RichTextBox();
            this.txtGameName = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcentCompletion
            // 
            this.lblProcentCompletion.AutoSize = true;
            this.lblProcentCompletion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcentCompletion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProcentCompletion.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProcentCompletion.Location = new System.Drawing.Point(12, 93);
            this.lblProcentCompletion.Name = "lblProcentCompletion";
            this.lblProcentCompletion.Size = new System.Drawing.Size(194, 21);
            this.lblProcentCompletion.TabIndex = 17;
            this.lblProcentCompletion.Text = "Procent Completion (in %)";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGameName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGameName.Location = new System.Drawing.Point(12, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(96, 21);
            this.lblGameName.TabIndex = 16;
            this.lblGameName.Text = "Game Name";
            // 
            // txtProcentCompletion
            // 
            this.txtProcentCompletion.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcentCompletion.Location = new System.Drawing.Point(12, 117);
            this.txtProcentCompletion.Name = "txtProcentCompletion";
            this.txtProcentCompletion.Size = new System.Drawing.Size(241, 30);
            this.txtProcentCompletion.TabIndex = 15;
            this.txtProcentCompletion.Text = "";
            // 
            // txtGameName
            // 
            this.txtGameName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameName.Location = new System.Drawing.Point(12, 33);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(241, 30);
            this.txtGameName.TabIndex = 14;
            this.txtGameName.Text = "";
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
            this.btnClose.Location = new System.Drawing.Point(12, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.White;
            this.btnAddGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGame.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddGame.FlatAppearance.BorderSize = 3;
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.ForeColor = System.Drawing.Color.Black;
            this.btnAddGame.Location = new System.Drawing.Point(12, 177);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(241, 42);
            this.btnAddGame.TabIndex = 12;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            // 
            // formAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 269);
            this.Controls.Add(this.lblProcentCompletion);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtProcentCompletion);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddGame);
            this.Name = "formAddGame";
            this.Text = "formAddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcentCompletion;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.RichTextBox txtProcentCompletion;
        private System.Windows.Forms.RichTextBox txtGameName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddGame;
    }
}