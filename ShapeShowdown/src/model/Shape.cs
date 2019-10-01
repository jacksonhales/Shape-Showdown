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
        private float previousFacingAngle;

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

        public float FacingAngle
        {
            get { return facingAngle; }
            set { facingAngle = value; }
        }

        public float PreviousFacingAngle
        {
            get { return previousFacingAngle; }
            set { previousFacingAngle = value; }
        }


        public Shape(float _x, float _y, Color _color)
        {
            facingAngle = 358.5F;
            x = _x;
            y = _y;
            color = _color;
        }

        public abstract void Draw();

        public abstract void ThrustForward();

    }
}
