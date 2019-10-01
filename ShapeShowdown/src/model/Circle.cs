using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public class Circle : Shape
    {

        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(int _x, int _y, Color _color, int _radius) : base(_x, _y, _color)
        {
            radius = _radius;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void ThrustForward()
        {
            throw new NotImplementedException();
        }
    }
}
