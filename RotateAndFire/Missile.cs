using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RotateAndFire
{
    public class Missile
    {
        public float x, y, size;
        public float missileSpeed, missileSize;
        public float difficultyMultiplier;

        //checks whether the missile has collided with a bullet
        public bool hasCollided = false;

        public Missile(int _x, int _y, int _missileSize, int _missileSpeed)
        {
            x = _x;
            y = _y;
            missileSpeed = _missileSpeed;
            missileSize = _missileSize;
            //difficultyMultiplier = _difficultyMultiplier;
        }

        public bool Collision(Bullet b)
        {
            System.Drawing.Rectangle missileRec = new System.Drawing.Rectangle((int)x, (int)y, (int)missileSize, (int)size);
            System.Drawing.Rectangle bulletRec = new System.Drawing.Rectangle((int)b.x, (int)b.y, b.size, b.size);

            if (bulletRec.IntersectsWith(missileRec))
            {                          
                return true;                           
            }
            else
            {
                return false;
            }
        }

        public void MissileMove()
        {
            y = y + 1;
        }

        public void OffScreen(List<Missile> missiles, GameScreen f)
        {
            List<int> toRemove = new List<int>();

            //gets the index value of the bullets that have gone off screen and places them in
            //the toRemove list
            foreach (Missile m in missiles)
            {
                if (m.x < 0 - m.size || m.x > f.Width || m.y < 0 - m.size || m.y > f.Height)
                {
                    toRemove.Add(missiles.IndexOf(m));
                }
            }

            //reverse list so when removing you do so from the end of the list first
            toRemove.Reverse();

            foreach (int i in toRemove)
            {
                missiles.RemoveAt(i);
            }
        }
        
    }
}


