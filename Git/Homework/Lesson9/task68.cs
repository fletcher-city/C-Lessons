using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine("A(" + m + ", " + n + ") = " + result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}