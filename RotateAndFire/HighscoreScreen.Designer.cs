namespace RotateAndFire
{
    partial class HighscoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.top5Label = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highscores";
            // 
            // top5Label
            // 
            this.top5Label.AutoSize = true;
            this.top5Label.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5Label.ForeColor = System.Drawing.Color.White;
            this.top5Label.Location = new System.Drawing.Point(37, 97);
            this.top5Label.Name = "top5Label";
            this.top5Label.Size = new System.Drawing.Size(116, 288);
            this.top5Label.TabIndex = 1;
            this.top5Label.Text = "1. \r\n2.  \r\n3. \r\n4. \r\n5. \r\n\r\n";
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.backButton.Location = new System.Drawing.Point(90, 358);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(328, 38);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Press [Enter] to go back.";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.top5Label);
            this.Controls.Add(this.label1);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label top5Label;
        private System.Windows.Forms.Button backButton;
    }
}
