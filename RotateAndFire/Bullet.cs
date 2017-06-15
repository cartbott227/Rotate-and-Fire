using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RotateAndFire
{
    public class Bullet
    {
        public float x, y;
        float xChange, yChange;
        int speedMultiplier;

        public int size
        {
            get;
        }

        public Bullet()
        { }

        /// <summary>
        /// Creates bullets that can travel at any angle
        /// </summary>
        /// <param name="_x">starting x position on screen</param>
        /// <param name="_y">starting y position on screen</param>
        /// <param name="_size">size of bullet</param>
        /// <param name="_speed">speed measured along the angle</param>
        /// <param name="_xChange">horizontal speed, (left is negative)</param>
        /// <param name="_yChange">vertical speed, (right is negative)</param>
        public Bullet(float _x, float _y, int _size, int _speed, float _xChange, float _yChange)
        {
            x = _x;
            y = _y;
            speedMultiplier = _speed;
            size = _size;
            xChange = _xChange;
            yChange = _yChange;
        }
        
        /// <summary>
        /// Creates bullets that only move up, down, left, right, or at 45 degree angles
        /// </summary>
        /// <param name="_x">starting x position on screen</param>
        /// <param name="_y">starting y position on screen</param>
        /// <param name="_size">size of bullet</param>
        /// <param name="_xSpeed">horizontal speed of bullet, (left is negative)</param>
        /// <param name="_ySpeed">vertical speed of bullet, (up is negative)</param>
        public Bullet(int _x, int _y, int _size, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            xChange = _xSpeed;
            yChange = _ySpeed;

            //all movement based on speed sent to constuctor, hence mult value of 1
            speedMultiplier = 1;
        }

        /// <summary>
        /// Moves the bullet in straight line based on its speed value
        /// </summary>
        public void Move()
        {
            x += xChange * speedMultiplier;
            y += yChange * speedMultiplier;
        }

        public void OffScreen(List<Bullet> bullets, UserControl f)
        {
            List<int> toRemove = new List<int>();

            //gets the index value of the bullets that have gone off screen and places them in
            //the toRemove list
            foreach (Bullet b in bullets)
            {
                if (b.x < 0 - b.size || b.x > f.Width || b.y < 0 - b.size || b.y > f.Height)
                {
                    toRemove.Add(bullets.IndexOf(b));
                }
            }

            //reverse list so when removing you do so from the end of the list first
            toRemove.Reverse();

            foreach (int i in toRemove)
            {
                bullets.RemoveAt(i);
            }
        }     
    }
}
