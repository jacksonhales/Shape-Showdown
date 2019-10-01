using SwinGameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.src
{
    public abstract class Shape
    {
        private float x;
        private float y;
        private Color color;
        private float facingAngle;

        public float FacingAngle
        {
            get { return facingAngle; }
            set { facingAngle = value; }
        }

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

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape(float _facingAngle, float _x, float _y, Color _color)
        {
            facingAngle = _facingAngle;
            x = _x;
            y = _y;
            color = _color;
        }

        public abstract void Draw();

        public abstract void RotateLeft();

        public abstract void RotateRight();

        public abstract void ThrustForward();

    }
}
