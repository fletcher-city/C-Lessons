using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));

        Console.WriteLine($"Максимальное число: {max}");
    }
}