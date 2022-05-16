using System;
public class Problem2
{
    public static void Main()
    {
        Console.Write("Enter number of rows: ");
        int r = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            for (int j = 1; j < r - i; j++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

        }

    }
}