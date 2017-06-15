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

        public Missile(int _x, int _y, int _missileSize, int _missileSpeed, int _difficultyMultiplier)
        {
            x = _x;
            y = _y;
            missileSpeed = _missileSpeed;
            missileSize = _missileSize;
            difficultyMultiplier = _difficultyMultiplier;
        }

        public bool Collision(Bullet b)
        {
            System.Drawing.Rectangle missileRec = new System.Drawing.Rectangle((int)x, (int)y, (int)size, (int)size);
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
    }
}


