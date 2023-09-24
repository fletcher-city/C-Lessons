using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделяя их запятой:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int count = 0;
        foreach (string number in numbers)
        {
            int num = int.Parse(number.Trim());
            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больше 0 равно: " + count);
    }
}