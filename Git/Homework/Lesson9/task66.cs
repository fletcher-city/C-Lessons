using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 15;
        int sum = CalculateSum(M, N);
        Console.WriteLine("Сумма натуральных элементов от " + M + " до " + N + ": " + sum);
    }

    static int CalculateSum(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}