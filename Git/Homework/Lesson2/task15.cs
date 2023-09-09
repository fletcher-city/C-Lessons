using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели:");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
    }
}
