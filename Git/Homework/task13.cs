using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число:");
        string numberString = Console.ReadLine();

        if (numberString.Length >= 3)
        {
            char thirdDigit = numberString[2];
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}
