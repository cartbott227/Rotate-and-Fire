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
    public partial class MenuScreen : UserControl
    {
        //determines whether a key is being pressed or not - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            DifficultyScreen ds = new DifficultyScreen();

            // Add the User Control to the Form
            f.Controls.Add(ds);
        }

        private void startButton_Enter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.GreenYellow;
            exitButton.ForeColor = Color.White;
            highscoresButton.ForeColor = Color.White;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.White;
            exitButton.ForeColor = Color.GreenYellow;
            highscoresButton.ForeColor = Color.White;
        }

        private void highscoresButton_Enter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.White;
            exitButton.ForeColor = Color.White;
            highscoresButton.ForeColor = Color.GreenYellow;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void highscoresButton_Click(object sender, EventArgs e)
        {

        }

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void MenuScreen_KeyUp(object sender, KeyEventArgs e)
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
