using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Created by Mr. T
 * to demonstrate how to use key presses to control the animation
 * of an object on screen
 */

namespace RotateAndFire
{
    public partial class Form1 : Form
    {
        public static int difficultyMultiplier = 1;
        public Form1()
        {
            InitializeComponent();


            // Create an instance of the DifficultyScreen
            MenuScreen ms = new MenuScreen();

            // Add the User Control to the Form
            this.Controls.Add(ms);
        }
    }
}


        