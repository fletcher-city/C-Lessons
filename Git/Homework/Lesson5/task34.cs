using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[4];

        // Ввод массива из трехзначных чисел
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите {i+1}-е трехзначное число: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            // Проверка на трехзначность числа
            while (numbers[i] < 100 || numbers[i] > 999)
            {
                Console.WriteLine("Введенное число не является трехзначным. Пожалуйста, введите трехзначное число.");
                Console.Write($"Введите {i+1}-е трехзначное число: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int evenCount = 0;

        // Подсчет количества четных чисел в массиве
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}
