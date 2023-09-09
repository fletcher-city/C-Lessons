using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N:");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Четные числа от 1 до N:");
        for (int i = 2; i <= N; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}
