using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RotateAndFire
{
    public partial class DifficultyScreen : UserControl
    {
        //determines whether a key is being pressed or not - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;

        public DifficultyScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {         
            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            GameScreen gs = new GameScreen();

            // Add the User Control to the Form
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            //set missile speed to 3
            Form1.difficulty = 30;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            GameScreen gs = new GameScreen();

            // Add the User Control to the Form
            f.Controls.Add(gs);
            gs.Focus();

            //change difficulty
            Form1.difficulty = 30;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            //set missile speed to 6
            Form1.difficulty = 15;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            GameScreen gs = new GameScreen();

            // Add the User Control to the Form
            f.Controls.Add(gs);
            gs.Focus();

            //change difficulty
            Form1.difficulty = 15;
        }

        private void DifficultyScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void easyButton_Enter(object sender, EventArgs e)
        {
            //change highlighted button colour
            hardButton.ForeColor = Color.Red;
            easyButton.ForeColor = Color.GreenYellow;
            mediumButton.ForeColor = Color.Red;
        }

        private void mediumButton_Enter(object sender, EventArgs e)
        {
            //change highlighted button colour
            hardButton.ForeColor = Color.Red;
            easyButton.ForeColor = Color.Red;
            mediumButton.ForeColor = Color.GreenYellow;
        }

        private void hardButton_Enter(object sender, EventArgs e)
        {
            //change highlighted button colour
            hardButton.ForeColor = Color.GreenYellow;
            easyButton.ForeColor = Color.Red;
            mediumButton.ForeColor = Color.Red;
        }

        private void DifficultyScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }
    }    
}
