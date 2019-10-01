using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public class Line : Shape
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Line(float _facingAngle, int _x, int _y, Color _color, int _length, int _width) : base(_facingAngle, _x, _y, _color)
        {
            length = _length;
            width = _width;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void RotateRight()
        {
            throw new NotImplementedException();
        }
    }
}
