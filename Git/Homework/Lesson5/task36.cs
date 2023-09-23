using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[4];


        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите значение для элемента {i+1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += numbers[i];
            }
        }


        Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
    }
}