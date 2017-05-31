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
        //determines whether a key is being pressed or not - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;

        //create graphic objects
        SolidBrush bulletBrush = new SolidBrush(Color.White);
        SolidBrush missileBrush = new SolidBrush(Color.Red);

        //bullet objects
        List<Bullet> bullets = new List<Bullet>();
        int bulletSpeed, bulletSize;

        //missile objects
        List<Missile> missiles = new List<Missile>();
        int missileSpeed, missileSize;

        //hero object
        Character hero;

        public Form1()
        { 
            InitializeComponent();
            OnStart();

            //start the timer when the program starts
            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        public void OnStart()
        {
            //initial starting values for hero object
            int speedHero = 6;
            int widthHero = 20;
            int heightHero = 20;
            int heroAngle = 0;
            int xHero = this.Width / 2 - widthHero / 2;
            int yHero = this.Height - 20;

            hero = new Character(xHero, yHero, widthHero, heightHero, speedHero, heroAngle);

            //initial starting values for bullet and missile objects
            bulletSpeed = 6;
            bulletSize = 6;

            missileSpeed = 2;
            missileSize = 6;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //rotate left
            if (leftArrowDown)
            {
                if (hero.angle  > - 50 )
                {
                    hero.Turn("left");
                }
            }

            //rotate right
            if (rightArrowDown)
            {
                if (hero.angle < 50)
                {
                    hero.Turn("right");
                }
            }
            
            //fire bullet
            if (spaceDown)
            {
                //theta measure for angle of fire, (float uses less memory)
                float thetaAngle = (90 - hero.angle);

                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //bullet object requires float values to draw on screen
                Bullet b = new Bullet(hero.x, hero.y, bulletSize, bulletSpeed, (float)xStep, (float)-yStep);
                bullets.Add(b);
            }

            //move bullet
            foreach (Bullet b in bullets)
            {
                b.Move();
            }

                        if (bullets.Count > 0)
            {
                //Use the OffScreen method from the first bullet since we know it exists.
                bullets[0].OffScreen(bullets, this);     
            }

            //paint the screen
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //find the centre of the hero to set the origin point where rotation will happen
            e.Graphics.TranslateTransform(hero.width/2 + hero.x, hero.width / 2 + hero.y);

            //rotate by the given angle for the hero
            e.Graphics.RotateTransform(hero.angle);

            // draw the object in the middle of the rotated origin point
            e.Graphics.FillRectangle(bulletBrush, 0 - hero.width / 2, 0 - hero.width / 2, hero.width , hero.height );

            //reset to original origin point
            e.Graphics.ResetTransform();

            foreach (Bullet b in bullets)
            {
                e.Graphics.FillEllipse(bulletBrush, 
                    b.x + hero.width/2 - bulletSize/2, b.y + hero.height / 2 - bulletSize / 2, 
                    bulletSize, bulletSize);
            }
        }

    }

}
