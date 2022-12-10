using ShapesTask.Helper;

namespace ShapesTask.Models
{
    public class Triangle : Shape
    {
        public Triangle(int height, char symbol, ConsoleColor color, int x, int y)
        {
            Height = height;
            Symbol = symbol;
            Color = color;
            X = x;
            Y = y;
        }
        public override void Draw(char? symbol = null)
        {
            symbol ??= Symbol;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
            for (int row = 1, h = Y; row <= Height; row++)
            {
                Console.SetCursorPosition(X - row, ++h);
                for (int j = 0; j <= row * 2; j++)
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
                    if (X < Console.WindowWidth - 11) X++;

                    Draw();
                }
                else if (key.IsLeft() && X > Height)
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
