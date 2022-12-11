using ShapesTask.Helper;

namespace ShapesTask.Models
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
        private int x;
        public int X
        {
            get { return x; }
            set { if (value > 0) x = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { if (value > 0) y = value; }
        }
        protected abstract void Draw(char? symbol = null);
        protected virtual void Move()
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

        public virtual void DrawAndMove()
        {
            Draw();
            Move();
        }
    }
}
