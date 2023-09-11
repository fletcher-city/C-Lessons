using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        int tempNumber = number;
        
        while(tempNumber != 0)
        {
            int digit = tempNumber % 10;
            sum += digit;
            tempNumber /= 10;
        }
        
        Console.WriteLine($"Сумма цифр числа {number} равна: {sum}");
    }
}
