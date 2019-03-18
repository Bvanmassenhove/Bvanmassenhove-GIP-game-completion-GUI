namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formDeleteGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDeleteGame));
            this.lblPickAGame = new System.Windows.Forms.Label();
            this.cmbPickAGame = new System.Windows.Forms.ComboBox();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPickAGame
            // 
            this.lblPickAGame.AutoSize = true;
            this.lblPickAGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickAGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPickAGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPickAGame.Location = new System.Drawing.Point(12, 9);
            this.lblPickAGame.Name = "lblPickAGame";
            this.lblPickAGame.Size = new System.Drawing.Size(100, 21);
            this.lblPickAGame.TabIndex = 24;
            this.lblPickAGame.Text = "Pick A Game";
            // 
            // cmbPickAGame
            // 
            this.cmbPickAGame.FormattingEnabled = true;
            this.cmbPickAGame.Location = new System.Drawing.Point(12, 33);
            this.cmbPickAGame.Name = "cmbPickAGame";
            this.cmbPickAGame.Size = new System.Drawing.Size(121, 21);
            this.cmbPickAGame.TabIndex = 23;
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.BackColor = System.Drawing.Color.White;
            this.btnDeleteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGame.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteGame.FlatAppearance.BorderSize = 3;
            this.btnDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteGame.Location = new System.Drawing.Point(12, 73);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(241, 42);
            this.btnDeleteGame.TabIndex = 25;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(16, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formDeleteGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 268);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.lblPickAGame);
            this.Controls.Add(this.cmbPickAGame);
            this.Name = "formDeleteGame";
            this.Text = "formDeleteGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPickAGame;
        private System.Windows.Forms.ComboBox cmbPickAGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnClose;
    }
}