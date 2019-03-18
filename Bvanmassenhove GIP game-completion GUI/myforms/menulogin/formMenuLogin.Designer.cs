namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formMenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuLogin));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnGameOptions = new System.Windows.Forms.Button();
            this.btnAccountOptions = new System.Windows.Forms.Button();
            this.btnShowGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.FlatAppearance.BorderSize = 3;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(12, 222);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(95, 34);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGameOptions
            // 
            this.btnGameOptions.BackColor = System.Drawing.Color.White;
            this.btnGameOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameOptions.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnGameOptions.FlatAppearance.BorderSize = 3;
            this.btnGameOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameOptions.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameOptions.ForeColor = System.Drawing.Color.Black;
            this.btnGameOptions.Location = new System.Drawing.Point(12, 60);
            this.btnGameOptions.Name = "btnGameOptions";
            this.btnGameOptions.Size = new System.Drawing.Size(241, 42);
            this.btnGameOptions.TabIndex = 4;
            this.btnGameOptions.Text = "Game Options ";
            this.btnGameOptions.UseVisualStyleBackColor = false;
            this.btnGameOptions.Click += new System.EventHandler(this.btnGameOptions_Click);
            // 
            // btnAccountOptions
            // 
            this.btnAccountOptions.BackColor = System.Drawing.Color.White;
            this.btnAccountOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountOptions.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnAccountOptions.FlatAppearance.BorderSize = 3;
            this.btnAccountOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountOptions.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountOptions.ForeColor = System.Drawing.Color.Black;
            this.btnAccountOptions.Location = new System.Drawing.Point(12, 108);
            this.btnAccountOptions.Name = "btnAccountOptions";
            this.btnAccountOptions.Size = new System.Drawing.Size(241, 42);
            this.btnAccountOptions.TabIndex = 3;
            this.btnAccountOptions.Text = "Account Options";
            this.btnAccountOptions.UseVisualStyleBackColor = false;
            this.btnAccountOptions.Click += new System.EventHandler(this.btnAccountOptions_Click);
            // 
            // btnShowGames
            // 
            this.btnShowGames.BackColor = System.Drawing.Color.White;
            this.btnShowGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowGames.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnShowGames.FlatAppearance.BorderSize = 3;
            this.btnShowGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGames.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGames.ForeColor = System.Drawing.Color.Black;
            this.btnShowGames.Location = new System.Drawing.Point(12, 12);
            this.btnShowGames.Name = "btnShowGames";
            this.btnShowGames.Size = new System.Drawing.Size(241, 42);
            this.btnShowGames.TabIndex = 6;
            this.btnShowGames.Text = "Show Games";
            this.btnShowGames.UseVisualStyleBackColor = false;
            this.btnShowGames.Click += new System.EventHandler(this.btnShowGames_Click);
            // 
            // formMenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 268);
            this.Controls.Add(this.btnShowGames);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGameOptions);
            this.Controls.Add(this.btnAccountOptions);
            this.Name = "formMenuLogin";
            this.Text = "formMenuLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnGameOptions;
        private System.Windows.Forms.Button btnAccountOptions;
        private System.Windows.Forms.Button btnShowGames;
    }
}