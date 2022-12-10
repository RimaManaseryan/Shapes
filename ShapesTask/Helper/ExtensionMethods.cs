namespace ShapesTask.Helper
{
    public static class ExtensionMethods
    {
        public static bool IsRight(this ConsoleKey @this) => @this == ConsoleKey.D || @this == ConsoleKey.RightArrow;
        public static bool IsLeft(this ConsoleKey @this) => @this == ConsoleKey.A || @this == ConsoleKey.LeftArrow;
        public static bool IsUp(this ConsoleKey @this) => @this == ConsoleKey.W || @this == ConsoleKey.UpArrow;
        public static bool IsDown(this ConsoleKey @this) => @this == ConsoleKey.S || @this == ConsoleKey.DownArrow;

    }
}
