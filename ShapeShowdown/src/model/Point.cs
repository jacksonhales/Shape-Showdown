using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.src.model
{
    public class Point
    {
        private float x;
        private float y;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

    }
}
