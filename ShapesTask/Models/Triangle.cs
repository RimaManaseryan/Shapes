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
        protected override void Draw(char? symbol = null)
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
    }
}
