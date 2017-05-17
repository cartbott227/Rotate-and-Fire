using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotateAndFire
{
    public class Character
    {
        public int x, y, width, height, speed, angle;

        public Character(int _x, int _y, int _width, int _height, int _speed, int _angle)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            angle = _angle;
        }

        public void Turn(string direction)
        {
            if (direction == "left")
            {
                angle -= speed;
            }
            else if (direction == "right")
            {
                angle += speed;
            }
        }
    }
}
