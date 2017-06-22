using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RotateAndFire
{
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();

            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            MenuScreen ms = new MenuScreen();


            // Add the User Control to the Form
            f.Controls.Add(ms);
            ms.Focus();
        }

        private void OnLoad()
        {
            //outputs highscores in format: (Position). NAME level# score 
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                if ((i + 1) >= 10)
                {
                    top5Label.Text += (i + 1) + ".  "  + Form1.highscoreList[i].score + "\n";
                }
                else
                {
                    top5Label.Text += (i + 1) + ".   " + Form1.highscoreList[i].score + "\n";
                }
            }
        }
    }
}
