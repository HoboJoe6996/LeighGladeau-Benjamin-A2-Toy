﻿namespace LeighGladeau_Benjamin_A2_Toy
    using Raylib.Cs;
    using System.Numerics;
{
    public class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string ToyDemonstration = "Game Title"; // Window title
        static int screenWidth = 800; // Screen width
        static int screenHeight = 800; // Screen height
        static int targetFps = 60; // Target frames-per-second

        static void Main()
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(800, 600, ToyDemonstration);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(60);
            // Setup your game. This is a function YOU define.
            Setup();
            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.RayWhite);
                // Your game code here. This is a function YOU define.
                Update();
                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            // Your one-time setup code here
        }

        static void Update()
        {
            // Your game code run each frame here
        }
    }
}
