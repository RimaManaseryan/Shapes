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
        public abstract void Draw(char? symbol = null);
        public abstract void Move();
    }
}
