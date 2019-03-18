namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formGameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGameOptions));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
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
            // btnChangeGame
            // 
            this.btnChangeGame.BackColor = System.Drawing.Color.White;
            this.btnChangeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeGame.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeGame.FlatAppearance.BorderSize = 3;
            this.btnChangeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeGame.ForeColor = System.Drawing.Color.Black;
            this.btnChangeGame.Location = new System.Drawing.Point(12, 60);
            this.btnChangeGame.Name = "btnChangeGame";
            this.btnChangeGame.Size = new System.Drawing.Size(241, 42);
            this.btnChangeGame.TabIndex = 4;
            this.btnChangeGame.Text = "Change Game";
            this.btnChangeGame.UseVisualStyleBackColor = false;
            this.btnChangeGame.Click += new System.EventHandler(this.btnChangeGame_Click);
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
            this.btnAddGame.Location = new System.Drawing.Point(12, 12);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(241, 42);
            this.btnAddGame.TabIndex = 3;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
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
            this.btnDeleteGame.Location = new System.Drawing.Point(12, 108);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(241, 42);
            this.btnDeleteGame.TabIndex = 6;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // formGameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 269);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeGame);
            this.Controls.Add(this.btnAddGame);
            this.Name = "formGameOptions";
            this.Text = "GameOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnDeleteGame;
    }
}