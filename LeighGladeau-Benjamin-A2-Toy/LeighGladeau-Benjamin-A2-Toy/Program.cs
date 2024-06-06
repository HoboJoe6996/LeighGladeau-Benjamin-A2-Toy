namespace LeighGladeau_Benjamin_A2_Toy;
using Raylib_cs;
using System.Numerics;

public class Program
{
    // If you need variables in the Program class (outside functions), you must mark them as static
    static string ToyDemonstration = "Game Title"; // Window title
    static int screenWidth = 800; // Screen width
    static int screenHeight = 600; // Screen height
    static int targetFps = 60; // Target frames-per-second
    static Vector2 mousePosition = Raylib.GetMousePosition();
    static bool isMouseButtonPressed = Raylib.IsMouseButtonPressed(MouseButton, button);
    static Random rng = new Random();
    static int shapeCounter = 0;
    static int maxShapeCount = 60;
    static Vector2 position = new Vector2[60];
    static Color GetRngColor()
    {
        Color rngColors = [Color.Red, Color.Blue, Color.Purple, Color.Violet, Color.Orange, Color.DarkGray, Color.Gold,
                           Color.Lime, Color.White, Color.Pink];
        Random rng = new Random();
        Color color = rng.Next(rngColors);
        return color;
    }
    static Vector2 GetRandomPosition()
    {
        Vector2 position;
        position.X = rng.Next(0, 800);
        position.Y = rng.Next(0, 600);
        return position;
    }
    static int GetRngDimensions()
    {
        int width = [1, 100];
        int height = [1, 125];
        int rngDimensions = [width, height];
        Random rng = new Random();
        int dimension = rng.Next(rngDimensions);
        return dimension;
    }
    //Start of my program
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
            Raylib.ClearBackground(Color.Black);
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
        Vector2[] position;
        Vector2[] dimension;
        Color[] color;
    }
    static void Update()
    {
        Vector2 mousePosition;
        if (isMouseButtonPressed = true && shapeCounter < 60)
        {
            Vector2 position = GetRandomPosition();
            Vector2 dimension = GetRngDimensions();
            Vector2 color = GetRngColor();
            ++shapeCounter;
        }
    }
}
