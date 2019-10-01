using System;
using SwinGameSDK;
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

            src.Triangle t = new src.Triangle(400, 275, Color.Black, 425, 225, 450, 275);

            //Run the game loop
            while (false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                //SwinGame.DrawFramerate(0,0);


                t.Draw();

                if (SwinGame.KeyDown(KeyCode.RightKey))
                {
                    t.Direction = ShipMoveDirection.RIGHT;
                    t.UpdateTriangle();
                }

                if (SwinGame.KeyDown(KeyCode.LeftKey))
                {
                    t.Direction = ShipMoveDirection.LEFT;
                    t.UpdateTriangle();
                }

                if (SwinGame.KeyDown(KeyCode.UpKey))
                {
                    t.ThrustForward();
                }

                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}