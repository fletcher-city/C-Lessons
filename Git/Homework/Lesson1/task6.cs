using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для определения четности:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Да, число является четным.");
        }
        else
        {
            Console.WriteLine("Нет, число не является четным.");
        }
    }
}