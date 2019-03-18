namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formChangeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangeGame));
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbPickAGame = new System.Windows.Forms.ComboBox();
            this.lblChangeProcent = new System.Windows.Forms.Label();
            this.lblChangeName = new System.Windows.Forms.Label();
            this.txtChangeProcent = new System.Windows.Forms.RichTextBox();
            this.txtChangeName = new System.Windows.Forms.RichTextBox();
            this.lblPickAGame = new System.Windows.Forms.Label();
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
            this.btnClose.Location = new System.Drawing.Point(12, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbPickAGame
            // 
            this.cmbPickAGame.FormattingEnabled = true;
            this.cmbPickAGame.Location = new System.Drawing.Point(12, 33);
            this.cmbPickAGame.Name = "cmbPickAGame";
            this.cmbPickAGame.Size = new System.Drawing.Size(121, 21);
            this.cmbPickAGame.TabIndex = 7;
            // 
            // lblChangeProcent
            // 
            this.lblChangeProcent.AutoSize = true;
            this.lblChangeProcent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChangeProcent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangeProcent.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblChangeProcent.Location = new System.Drawing.Point(12, 148);
            this.lblChangeProcent.Name = "lblChangeProcent";
            this.lblChangeProcent.Size = new System.Drawing.Size(167, 21);
            this.lblChangeProcent.TabIndex = 21;
            this.lblChangeProcent.Text = "Change Procent (in %)";
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChangeName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChangeName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblChangeName.Location = new System.Drawing.Point(12, 64);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(109, 21);
            this.lblChangeName.TabIndex = 20;
            this.lblChangeName.Text = "change Name ";
            // 
            // txtChangeProcent
            // 
            this.txtChangeProcent.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeProcent.Location = new System.Drawing.Point(12, 172);
            this.txtChangeProcent.Name = "txtChangeProcent";
            this.txtChangeProcent.Size = new System.Drawing.Size(241, 30);
            this.txtChangeProcent.TabIndex = 19;
            this.txtChangeProcent.Text = "";
            // 
            // txtChangeName
            // 
            this.txtChangeName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeName.Location = new System.Drawing.Point(12, 99);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(241, 30);
            this.txtChangeName.TabIndex = 18;
            this.txtChangeName.Text = "";
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
            this.lblPickAGame.TabIndex = 22;
            this.lblPickAGame.Text = "Pick A Game";
            // 
            // formChangeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 269);
            this.Controls.Add(this.lblPickAGame);
            this.Controls.Add(this.lblChangeProcent);
            this.Controls.Add(this.lblChangeName);
            this.Controls.Add(this.txtChangeProcent);
            this.Controls.Add(this.txtChangeName);
            this.Controls.Add(this.cmbPickAGame);
            this.Controls.Add(this.btnClose);
            this.Name = "formChangeGame";
            this.Text = "formChangeGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbPickAGame;
        private System.Windows.Forms.Label lblChangeProcent;
        private System.Windows.Forms.Label lblChangeName;
        private System.Windows.Forms.RichTextBox txtChangeProcent;
        private System.Windows.Forms.RichTextBox txtChangeName;
        private System.Windows.Forms.Label lblPickAGame;
    }
}