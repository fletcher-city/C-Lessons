using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSumRow = 1; // Изменено значение на 1
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i + 1; // Изменено значение на i + 1
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow);
    }
}