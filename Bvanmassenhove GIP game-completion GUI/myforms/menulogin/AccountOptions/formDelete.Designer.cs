namespace Bvanmassenhove_GIP_game_completion_GUI
{
    partial class formDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDelete));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "type DELETE to delete your account";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.White;
            this.btnDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnDELETE.FlatAppearance.BorderSize = 3;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.Black;
            this.btnDELETE.Location = new System.Drawing.Point(12, 86);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(95, 34);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(361, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "formDelete";
            this.Text = "fomrDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button button1;
    }
}