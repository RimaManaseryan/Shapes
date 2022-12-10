using ShapesTask.Helper;

namespace ShapesTask.Models
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public Rectangle(int height, int width, char symbol, ConsoleColor color, int x, int y)
        {
            Height = height;
            Width = width;
            Symbol = symbol;
            Color = color;
            X = x;
            Y = y;
        }
        public override void Draw(char? symbol = null)
        {
            symbol ??= Symbol;
            Console.ForegroundColor = Color;
            for (int row = 0; row < Height; row++)
            {
                Console.SetCursorPosition(X, Y + row > 0 ? Y + row : row);
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(symbol);
                }
            }
        }
        public override void Move()
        {
            while (Console.ReadKey(true) is ConsoleKeyInfo keyInfo &&
            keyInfo.Key is ConsoleKey key && key != ConsoleKey.Escape)
            {
                if (key.IsRight())
                {
                    Draw(' ');
                    if (X < Console.WindowWidth - 11)
                        X++;
                    Draw();
                }
                else if (key.IsLeft())
                {
                    Draw(' ');
                    X--;
                    Draw();
                }
                else if (key.IsUp())
                {
                    Draw(' ');
                    Y--;
                    Draw();
                }
                else if (key.IsDown())
                {
                    Draw(' ');
                    Y++;
                    Draw();
                }
            }
        }
    }
}
