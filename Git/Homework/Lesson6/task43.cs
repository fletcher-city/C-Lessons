using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения b1, k1, b2 и k2:");

        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения: ({0}; {1})", x, y);
    }
}
