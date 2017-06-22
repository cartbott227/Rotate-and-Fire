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
    public partial class GameoverScreen : UserControl
    {
        public GameoverScreen()
        {
            InitializeComponent();

            //display final score
            finalscoreLabel.Text = "You destroyed " + Form1.score.ToString() + " missiles!";

            Highscore currentscore = new Highscore(Form1.score.ToString());

            ///add current score to highscores list
            Form1.highscoreList.Add(currentscore);
        }

        private void menuButton_Click(object sender, EventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            //end game
            Application.Exit();
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            //change colour of selected button
            menuButton.ForeColor = Color.White;
            exitButton.ForeColor = Color.GreenYellow;
        }

        private void menuButton_Enter(object sender, EventArgs e)
        {
            //change colour of selected button
            menuButton.ForeColor = Color.GreenYellow;
            exitButton.ForeColor = Color.White;
        }
    }
}
