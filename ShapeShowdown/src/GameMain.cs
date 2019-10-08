using System;
using SwinGameSDK;
using MyGame.src;
using MyGame.src.model;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            //SwinGame.ShowSwinGameSplashScreen();

            src.Triangle t = new src.Triangle(400, 275, Color.Black, 425, 325, 450, 275);

            //Run the game loop
            while (false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                //SwinGame.DrawFramerate(0,0);


                t.Draw();

                if (SwinGame.KeyDown(KeyCode.DKey))
                {
                    t.Direction = ShipMoveDirection.RIGHT;
                    t.UpdateTriangle();
                }

                if (SwinGame.KeyDown(KeyCode.AKey))
                {
                    t.Direction = ShipMoveDirection.LEFT;
                    t.UpdateTriangle();
                }

                if (SwinGame.KeyDown(KeyCode.WKey))
                {
                    t.MoveForward();
                }

                if (SwinGame.KeyDown(KeyCode.SpaceKey))
                {
                    t.Shoot();
                    t.CanShoot = true;
                }

                SwinGame.DrawText("Facing Angle: " + t.FacingAngle.ToString(), Color.Black, 10, 10);
                SwinGame.DrawText("Center X: " + t.Center.X, Color.Black, 10, 20);
                SwinGame.DrawText("Center Y: " + t.Center.Y, Color.Black, 10, 30);

                if (t.ActiveShots.Count > 0)
                {
                    foreach (Line l in t.ActiveShots)
                    {
                        l.Draw();
                        l.MoveForward();
                    }
                }

                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}