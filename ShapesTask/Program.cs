using ShapesTask.Models;

Console.WriteLine("What shape do you want to Draw?");

Console.WriteLine("1. Rect\n2. Trg");
int shaperesp = int.Parse(Console.ReadLine()?.Trim() ?? "1");


Console.WriteLine("What Color do you like to use for shape?");
PrintColors();
ConsoleColor color = (ConsoleColor)int.Parse(Console.ReadLine()?.Trim() ?? "1");

Console.WriteLine("Type the symbol you want to draw the shape with.");
char symbol = char.Parse(Console.ReadLine()?.Trim() ?? "*");



Shape? shape =
shaperesp == 1 ? new Rectangle(4, 10, symbol, color, Console.WindowWidth / 2, Console.WindowHeight / 2) :
shaperesp == 2 ? new Triangle(6, symbol, color, Console.WindowWidth / 2, Console.WindowHeight / 2) : null;
shape?.Draw();
shape?.Move();


Console.ReadLine();

static void PrintColors()
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    ConsoleColor[]? Colors = Enum.GetValues(typeof(ConsoleColor)) as ConsoleColor[];
    for (int i = 0; i < Colors?.Length; i++)
    {
        Console.ForegroundColor = Colors[i];
        Console.WriteLine($"{i}. {Colors[i].GetType().GetEnumName(Colors[i])}");
    }
    Console.ForegroundColor = defaultColor;
}