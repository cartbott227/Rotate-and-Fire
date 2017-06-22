using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RotateAndFire
{
    public partial class GameScreen : UserControl
    {
        //determines whether a key is being pressed or not - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;

        //generate random missile location
        Random randGen = new Random();

        //create graphic objects
        SolidBrush bulletBrush = new SolidBrush(Color.White);
        SolidBrush missileBrush = new SolidBrush(Color.Red);

        //bullet objects
        public List<Bullet> bullets = new List<Bullet>();
        int bulletSpeed, bulletSize;

        //ammo
        int ammo = 100;

        //lives
        int lives = 5;

        //missile objects
        public List<Missile> missiles = new List<Missile>();
        public int x, y, missileSpeed, missileSize;

        //hero object
        Character hero;

        //missile timer
        public int counter = 0;

        //fire counter 
        int firecounter = 0;

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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

        //place holder 

        public GameScreen()
        {
            InitializeComponent();
            OnStart();

            //start the timer when the program starts
            gameTimer.Enabled = true;
            gameTimer.Start();

            Form1.sirenPlayer.Play();
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
            missileSize = 15;

            Missile m = new Missile(50, 90, missileSize, missileSpeed);
            missiles.Add(m);
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
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
                if (hero.angle > -80)
                {
                    hero.Turn("left");
                }
            }

            //rotate right
            if (rightArrowDown)
            {
                if (hero.angle < 80)
                {
                    hero.Turn("right");
                }
            }

            //spawn missile every 60 ticks
            if (counter == Form1.difficulty)
            {
                //missile object requires float values to draw on screen
                Missile m = new Missile(randGen.Next(10, this.Width - 10), 0, missileSize, missileSpeed);
                missiles.Add(m);

                //reset counter
                counter = 0;
            }
            else
            {
                counter++;
            }

            //fire bullet
            if (spaceDown && ammo > 0 && firecounter == 0)
            {
                //theta measure for angle of fire, (float uses less memory)
                float thetaAngle = (90 - hero.angle);

                // determine the end point for each hand (result must be a double)
                double xStep = Math.Cos(thetaAngle * Math.PI / 180.0);
                double yStep = Math.Sin(thetaAngle * Math.PI / 180.0);

                //bullet object requires float values to draw on screen
                Bullet b = new Bullet(hero.x, hero.y, bulletSize, bulletSpeed, (float)xStep, (float)-yStep);
                bullets.Add(b);

                //remove ammo
                ammo--;
                ammoLabel.Text = "Ammo: " + ammo.ToString();

                //reset firecounter
                firecounter = 0;
            }

            //move bullet
            foreach (Bullet b in bullets)
            {
                b.Move();
            }

            //move missile
            foreach (Missile m in missiles)
            {
                m.MissileMove();
            }

            if (bullets.Count > 0)
            {
                //Use the OffScreen method from the first bullet since we know it exists.
                //bullets[0].OffScreen(bullets, this);
            }

            //remove missile and health when missile hits bottom of screen
            foreach (Missile m in missiles)
            {
                if (m.y > this.Height)
                {
                    lives--;
                    livesLabel.Text = lives.ToString();
                    missiles.RemoveAt(missiles.IndexOf(m));
                    break;
                }
            }

            if (missiles.Count > 0)
            {
                //Use the OffScreen method from the first bullet since we know it exists.
                missiles[0].OffScreen(missiles, this);
            }
     
            BulletsMissilesCollision();

            //paint the screen
             Refresh();
        }

        public void BulletsMissilesCollision()
        {
            //will contain index values of all bullets that have collided with a monster
            List<int> bulletsToRemove = new List<int>();

            //will contain index values of all monsters that have collided with a bullet
            List<int> missilesToRemove = new List<int>();

            foreach (Bullet b in bullets)
            {
                foreach (Missile m in missiles)
                {
                    //uses collision method in monster class and returns true
                    //if monster 'm' has collided with bullet 'b'
                    if (m.Collision(b))
                    {
                        //checks to make sure that the bullet is not already in removal list
                        if (!bulletsToRemove.Contains(bullets.IndexOf(b)))
                        {
                            //add the index value from bullets of the bullet that collided 
                            bulletsToRemove.Add(bullets.IndexOf(b));
                            // bullets.Remove(b);
                            // missiles.Remove(m);
                        }

                        //checks to make sure that the monster is not already in removal list
                        if (!missilesToRemove.Contains(missiles.IndexOf(m)))
                        {
                            //add the index value from monsters of the monster that collided
                            missilesToRemove.Add(missiles.IndexOf(m));
                        }

                        //increase score 
                        Form1.score++;
                        scoreLabel.Text = "Score: " + Form1.score.ToString();

                        //increase ammo
                        ammo = ammo + 5;                      
                        ammoLabel.Text = "Ammo: " + ammo.ToString();

                        Form1.explosionPlayer.Play();
                    }
                }
            }

            //reverse lists so when removing you do so from the end of the list first
            bulletsToRemove.Reverse();
            missilesToRemove.Reverse();

            foreach (int i in bulletsToRemove)
            {
                bullets.RemoveAt(i);
            }

            foreach (int i in missilesToRemove)
            {
                missiles.RemoveAt(i);
            }

            //game over if out of lives
            if (lives == 0)
            {
                //wait for 1 second
                Thread.Sleep(1000);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                // Create an instance of the DifficultyScreen
                GameoverScreen os = new GameoverScreen();

                // Add the User Control to the Form
                f.Controls.Add(os);
                os.Focus();

                gameTimer.Stop();


            }
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //find the centre of the hero to set the origin point where rotation will happen
            e.Graphics.TranslateTransform(hero.width / 2 + hero.x, hero.width / 2 + hero.y);

            //rotate by the given angle for the hero
            e.Graphics.RotateTransform(hero.angle);

            // draw the object in the middle of the rotated origin point
            e.Graphics.FillRectangle(bulletBrush, 0 - hero.width / 2, 0 - hero.width / 2, hero.width, hero.height);

            //reset to original origin point
            e.Graphics.ResetTransform();

            foreach (Missile m in missiles)
            {
                e.Graphics.FillEllipse(bulletBrush,
                    m.x + hero.width / 2 - missileSize / 2, m.y + hero.height / 2 - missileSize / 2,
                    missileSize, bulletSize);
            }

            foreach (Bullet b in bullets)
            {
                e.Graphics.FillEllipse(missileBrush,
                    b.x + hero.width / 2 - bulletSize / 2, b.y + hero.height / 2 - bulletSize / 2,
                    bulletSize, bulletSize);
            }
        }
    }
}
