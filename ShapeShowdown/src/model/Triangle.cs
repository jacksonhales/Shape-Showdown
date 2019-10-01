using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.src.model;
using SwinGameSDK;

namespace MyGame.src
{
    public class Triangle : Shape
    {
        private Point verticeA;
        private Point verticeB;
        private Point verticeC;
        private Point center;

        public Point VerticeC
        {
            get { return verticeC; }
            set { verticeC = value; }
        }

        public Point VerticeB
        {
            get { return verticeB; }
            set { verticeB = value; }
        }


        public Point VerticeA
        {
            get { return verticeA; }
            set { verticeA = value; }
        }
        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

        public Triangle(float _facingAngle, float _startX, float _startY, Color _color, float _midX, float _midY, float _endX, float _endY) : base(_facingAngle, _startX, _startY, _color)
        {
            verticeA = new Point(_startX, _startY);
            verticeB = new Point(_midX, _midY);
            verticeC = new Point(_endX, _endY);
            center = FindCenter();
        }


        
        public Point FindCenter()
        {
            float centroidX = ((verticeA.X + verticeB.X + verticeC.X) / 3);
            float centroidY = ((verticeA.Y + verticeB.Y + verticeC.Y) / 3);
            return new Point(centroidX, centroidY);
        }

        public override void Draw()
        {
            center = FindCenter();
            SwinGame.FillTriangle(Color, verticeA.X, verticeA.Y, verticeB.X, verticeB.Y, verticeC.X, verticeC.Y);
        }

        public override void RotateRight()
        {


            float tempX = 0;
            float tempY = 0;

            // rotate point a
            verticeA.X = verticeA.X - center.X;
            verticeA.Y = verticeA.Y - center.Y;

            float previousFA = FacingAngle - 0.05F;

            tempX = (float)(verticeA.X * Math.Cos(FacingAngle - previousFA) -
                    verticeA.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeA.X * Math.Sin(FacingAngle - previousFA) +
                    verticeA.Y * Math.Cos(FacingAngle - previousFA));

            verticeA.X = tempX + center.X;
            verticeA.Y = tempY + center.Y;

            // rotate point b
            verticeB.X = verticeB.X - center.X;
            verticeB.Y = verticeB.Y - center.Y;

            tempX = (float)(verticeB.X * Math.Cos(FacingAngle - previousFA) -
                    verticeB.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeB.X * Math.Sin(FacingAngle - previousFA) +
                    verticeB.Y * Math.Cos(FacingAngle - previousFA));

            verticeB.X = tempX + center.X;
            verticeB.Y = tempY + center.Y;

            // rotate point c
            verticeC.X = verticeC.X - center.X;
            verticeC.Y = verticeC.Y - center.Y;

            tempX = (float)(verticeC.X * Math.Cos(FacingAngle - previousFA) -
                    verticeC.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeC.X * Math.Sin(FacingAngle - previousFA) +
                    verticeC.Y * Math.Cos(FacingAngle - previousFA));

            verticeC.X = tempX + center.X;
            verticeC.Y = tempY + center.Y;

        }

        public override void RotateLeft()
        {
            float tempX = 0;
            float tempY = 0;

            // rotate point a
            verticeA.X = verticeA.X - center.X;
            verticeA.Y = verticeA.Y - center.Y;

            float previousFA = FacingAngle + 0.05F;

            tempX = (float)(verticeA.X * Math.Cos(FacingAngle - previousFA) -
                    verticeA.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeA.X * Math.Sin(FacingAngle - previousFA) +
                    verticeA.Y * Math.Cos(FacingAngle - previousFA));

            verticeA.X = tempX + center.X;
            verticeA.Y = tempY + center.Y;

            // rotate point b
            verticeB.X = verticeB.X - center.X;
            verticeB.Y = verticeB.Y - center.Y;

            tempX = (float)(verticeB.X * Math.Cos(FacingAngle - previousFA) -
                    verticeB.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeB.X * Math.Sin(FacingAngle - previousFA) +
                    verticeB.Y * Math.Cos(FacingAngle - previousFA));

            verticeB.X = tempX + center.X;
            verticeB.Y = tempY + center.Y;

            // rotate point c
            verticeC.X = verticeC.X - center.X;
            verticeC.Y = verticeC.Y - center.Y;

            tempX = (float)(verticeC.X * Math.Cos(FacingAngle - previousFA) -
                    verticeC.Y * Math.Sin(FacingAngle - previousFA));

            tempY = (float)(verticeC.X * Math.Sin(FacingAngle - previousFA) +
                    verticeC.Y * Math.Cos(FacingAngle - previousFA));

            verticeC.X = tempX + center.X;
            verticeC.Y = tempY + center.Y;
        }

        public override void ThrustForward()
        {
            float horizontalVelocity = (float)(Math.Cos(FacingAngle));
            float verticalVelocity = (float)(Math.Sin(FacingAngle));

            // move the ship - 1 point at a time
            center.X = center.X + horizontalVelocity * 1;
            center.Y = center.Y + verticalVelocity * 1;

            verticeA.X = verticeA.X + horizontalVelocity * 1;
            verticeA.Y = verticeA.Y + verticalVelocity * 1;

            verticeB.X = verticeB.X + horizontalVelocity * 1;
            verticeB.Y = verticeB.Y + verticalVelocity * 1;

            verticeC.X = verticeC.X + horizontalVelocity * 1;
            verticeC.Y = verticeC.Y + verticalVelocity * 1;
        }

    }
}
