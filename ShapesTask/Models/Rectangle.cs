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
        protected override void Draw(char? symbol = null)
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
        
    }
}
