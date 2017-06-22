using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;
using System.Xml;

//Program created by Carter Bott
//on June 16th, 2017
//Description: A basic remake of the classic Atari Missile Command (1980).

//*NOTE*
//I attempted to add a highscore screen but was unable to complete the code for it in time, I have
//the basis of the code but am unable to output the scores to the highscore screen.

namespace RotateAndFire
{
    public partial class Form1 : Form
    {
        //difficulty
        public static int difficulty = 60;

        //score 
        public static int score = 0;

        //sounds
        public static SoundPlayer sirenPlayer = new SoundPlayer(Properties.Resources.siren);
        public static SoundPlayer explosionPlayer = new SoundPlayer(Properties.Resources.explosion);

        //Highscores list
        public static List<Highscore> highscoreList = new List<Highscore>();

        public Form1()
        {
            InitializeComponent();

            // Create an instance of the DifficultyScreen
            MenuScreen ms = new MenuScreen();

            // Add the User Control to the Form
            this.Controls.Add(ms);
        }

        //method for loading any saved highscores in the highscoreDB xml file
        private void loadHighscores() 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscores.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new Highscore(null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {

                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                    }
                }
                highscoreList.Add(hs);
            }
        }
    }
}


        