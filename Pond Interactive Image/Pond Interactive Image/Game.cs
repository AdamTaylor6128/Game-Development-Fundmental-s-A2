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
        int opacity = 255;
        int wavePos;
        int colRed;
        int colGreen;
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
            //Wave Drawings
            if(opacity <= 0)
            {
                //Resets the waves and changes positioning and color
                opacity = 255;
                wavePos = Random.Integer(-50, 50);
                colGreen = Random.Integer(-50, 100);
                colRed = Random.Integer(-20, 100);

            }
            else
            {
              //Draws the waves
              Draw.SetLineSize(10);
              Draw.SetFillColor(67, 49, 224, opacity);
              Draw.SetLineColor(66+colRed, 155+colGreen, 245, opacity);
              Draw.Arc(200+wavePos, 200+wavePos, 100, 66, 180, 360, false);
                Draw.Arc(70 + wavePos, 200 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(270 + wavePos, 100 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(150 + wavePos, 150 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(220 + wavePos, 300 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(320 + wavePos, 225 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(180 + wavePos, 70 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(200 + wavePos, 200 + wavePos, 100, 66, 180, 360, false);
                Draw.Arc(120 + wavePos, 325 + wavePos, 100, 66, 180, 360, false);
                opacity -= 2;
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
