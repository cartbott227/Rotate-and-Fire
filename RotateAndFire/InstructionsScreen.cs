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
    public partial class InstructionsScreen : UserControl
    {
        public InstructionsScreen()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();

            f.Controls.Remove(this);

            // Create an instance of the DifficultyScreen
            DifficultyScreen ds = new DifficultyScreen();


            // Add the User Control to the Form
            f.Controls.Add(ds);
            ds.Focus();
        }
    }
}
