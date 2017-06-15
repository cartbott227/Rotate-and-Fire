namespace RotateAndFire
{
    partial class DifficultyScreen
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
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Difficulty";
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.BorderSize = 0;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.Red;
            this.easyButton.Location = new System.Drawing.Point(93, 99);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(309, 74);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Defcon 3";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            this.easyButton.Enter += new System.EventHandler(this.easyButton_Enter);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.BorderSize = 0;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.Red;
            this.mediumButton.Location = new System.Drawing.Point(93, 179);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(309, 74);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Defcon 2";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            this.mediumButton.Enter += new System.EventHandler(this.mediumButton_Enter);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.BorderSize = 0;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.Red;
            this.hardButton.Location = new System.Drawing.Point(93, 259);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(309, 74);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Defcon 1";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            this.hardButton.Enter += new System.EventHandler(this.hardButton_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(148, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press [Enter] to begin mission";
            // 
            // DifficultyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.label1);
            this.Name = "DifficultyScreen";
            this.Size = new System.Drawing.Size(500, 400);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DifficultyScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DifficultyScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label label2;
    }
}
