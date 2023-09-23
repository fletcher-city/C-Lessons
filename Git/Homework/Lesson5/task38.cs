using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        
        double[] numbers = new double[size];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите значение для элемента {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

       
        double max = numbers[0];
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        
        double difference = max - min;

        
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}