using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public class Square : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }


        public Square(int _x, int _y, Color _color, int _width, int _height) : base(_x, _y, _color)
        {
            height = _height;
            width = _width;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void MoveForward()
        {
            throw new NotImplementedException();
        }
    }
}
