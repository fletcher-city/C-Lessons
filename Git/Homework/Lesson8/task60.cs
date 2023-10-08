using System;

class Program
{
    static void Main()
    {
        int[,,] array = new int[2, 2, 2];
        int num = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num;
                    num++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
                }
            }
        }
    }
}