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

        public Missile(int _x, int _y, int _missileSize, int _missileSpeed, int _difficultyMultiplier)
        {
            x = _x;
            y = _y;
            missileSpeed = _missileSpeed;
            missileSize = _missileSize;
            difficultyMultiplier = _difficultyMultiplier;
        }
    }
}


