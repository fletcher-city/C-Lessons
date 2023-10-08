using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] array = new int[n, n];

        int value = 1;
        int startRow = 0, endRow = n - 1;
        int startCol = 0, endCol = n - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
         
            for (int i = startCol; i <= endCol; i++)
            {
                array[startRow, i] = value;
                value++;
            }
            startRow++;

       
            for (int i = startRow; i <= endRow; i++)
            {
                array[i, endCol] = value;
                value++;
            }
            endCol--;

      
            for (int i = endCol; i >= startCol; i--)
            {
                array[endRow, i] = value;
                value++;
            }
            endRow--;

    
            for (int i = endRow; i >= startRow; i--)
            {
                array[i, startCol] = value;
                value++;
            }
            startCol++;
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}