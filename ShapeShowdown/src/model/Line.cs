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
        private float endX;
        private float endY;
        private Triangle shotBy;

        public Triangle ShotBy
        {
            get { return shotBy; }
            set { shotBy = value; }
        }

        public float EndX
        {
            get { return endX; }
            set { endX = value; }
        }
        public float EndY
        {
            get { return endY; }
            set { endY = value; }
        }

        public Line(float _x, float _y, Color _color, float _endX, float _endY, Triangle _shotBy) : base(_x, _y, _color)
        {
            endX = _endX;
            endY = _endY;
            shotBy = _shotBy;
            FacingAngle = shotBy.FacingAngle;
        }

        public override void Draw()
        {
            SwinGame.DrawLine(Color, X, Y, EndX, EndY);
        }

        public override void MoveForward()
        {
            float horizontalVelocity = (float)(Math.Cos(FacingAngle)) * 3;
            float verticalVelocity = (float)(Math.Sin(FacingAngle)) * 3;

            endX = endX + horizontalVelocity;
            endY = endY + verticalVelocity;

            X = X + horizontalVelocity;
            Y = Y + verticalVelocity;
        }
    }
}
