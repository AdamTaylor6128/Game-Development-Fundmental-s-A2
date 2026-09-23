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
        public void Setup()
        {
            Window.SetTitle("Lily Pond");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(67, 49, 224);
            
            
            //Lily Pad Drawings all postive away from mouse position
            Draw.SetFillColor(Color.Green);
            Draw.SetLineSize(5);
            Draw.SetLineColor(49, 224, 52);
            Draw.Arc(310+Input.GetMouseX(), 110+Input.GetMouseY(), 140, 140, 0, 300);
            Draw.Line(310+Input.GetMouseX(), 110+Input.GetMouseY(), 260+Input.GetMouseX(), 150+Input.GetMouseY());
            Draw.Arc(70 + Input.GetMouseX(), 330 + Input.GetMouseY(), 80, 80, 180, -90);
            Draw.Line(70 + Input.GetMouseX(), 330 + Input.GetMouseY(), 90 + Input.GetMouseX(), 350 + Input.GetMouseY());
            Draw.Arc(330 + Input.GetMouseX(), 370 + Input.GetMouseY(), 100, 100, 90, 400 );
            Draw.Line(310 + Input.GetMouseX(), 330 + Input.GetMouseY(), 330 + Input.GetMouseX(), 370 + Input.GetMouseY());
            Draw.SetFillColor(67, 49, 224);
            Draw.SetLineSize(5);
            Draw.SetLineColor(49, 224, 52);
            Draw.PolyLine(int[60, 70, 80, 90, 100], int[140, 130, 120, 130, 140]);
            
            

            
            
            
        }
    }

}
