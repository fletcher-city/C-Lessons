using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
