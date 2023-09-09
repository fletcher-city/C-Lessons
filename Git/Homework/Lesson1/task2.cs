using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);
        int min = Math.Min(a, b);

        Console.WriteLine($"Большее число: {max}");
        Console.WriteLine($"Меньшее число: {min}");
    }
}