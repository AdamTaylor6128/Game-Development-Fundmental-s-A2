// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        int rndPos;
        int arcShift;
        int opacityW = 255;
        int opacityR = 255;
        int wavePosX;
        int wavePosY;
        int colRed;
        int colGreen;
        int rad = 0;
        int x;
        int y;
        bool ripple = false;

        public void Setup()
        {
            Window.SetTitle("Lily Pond");
            Window.SetSize(400, 400);
            //Creates a random lily pad position each time
            rndPos = Random.Integer(200, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(67, 49, 224);
            
            
            //Creates ripples on click
            if(Input.IsMouseButtonPressed(MouseButton.Left))
            {
                ripple = true;
                x = Input.GetMouseX();
                y = Input.GetMouseY();
            }
            //Draw ripple if 
            if (ripple == true && rad < 50)
            {
                rad += 1;
                opacityR -= 5;
                Draw.SetLineSize(10);
                Draw.SetFillColor(67, 49, 224);
                Draw.SetLineColor(66, 155, 245, opacityR);
                Draw.Circle(x, y, rad);


            }
            //Reset ripple
            else if (rad == 50)
            {
                rad = 0;
                opacityR = 255;
                ripple = false;

            }

            //Wave Drawings
            if (opacityW <= 0)
            {
                //Resets the waves opacity
                opacityW = 255;
                //Changes wave position randomly
                wavePosX = Random.Integer(-50, 50);
                wavePosY = Random.Integer(-50, 50);

                //Changes wave colours randomly
                colGreen = Random.Integer(-50, 100);
                colRed = Random.Integer(-20, 100);

            }
            else
            {
              //Draws the waves
              Draw.SetLineSize(10);
              Draw.SetFillColor(67, 49, 224, opacityW);
              Draw.SetLineColor(66+colRed, 155+colGreen, 245, opacityW);
              Draw.Arc(200+wavePosX, 200 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(270 + wavePosX, 100 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(150 + wavePosX, 150 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(220 + wavePosX, 300 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(320 + wavePosX, 225 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(180 + wavePosX, 70 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(200 + wavePosX, 200 + wavePosY, 100, 66, 180, 360, false);
                Draw.Arc(120 + wavePosX, 325 + wavePosY, 100, 66, 180, 360, false);
                opacityW -= 2;
            }
            
            
            //Lily Pad Drawings
            Draw.SetFillColor(78, 230, 64);
            Draw.SetLineSize(5);
            Draw.SetLineColor(49, 224, 52);
            Draw.Arc((10 + rndPos) + Input.GetMouseX(), (-110 + rndPos) + Input.GetMouseY(), 140, 140, 0, 300);

            Draw.Arc(-270 + rndPos + Input.GetMouseX(), 130 + rndPos + Input.GetMouseY(), 80, 80, 180, -90);

            Draw.Arc(130 + rndPos + Input.GetMouseX(), 170 + rndPos + Input.GetMouseY(), 100, 100, 90, 400);

            Draw.Arc(310 - rndPos + Input.GetMouseX(), 110 - rndPos + Input.GetMouseY(), 140, 140, 0, 300);

            Draw.Arc(70 - rndPos + Input.GetMouseX(), 330 - rndPos + Input.GetMouseY(), 80, 80, 180, -90);

            Draw.Arc((330 - rndPos) + Input.GetMouseX(), (370 - rndPos) + Input.GetMouseY(), 100, 100, 90, 400);













        }
    }

}
