using System;
public class Problem2
{
    public static void Main()
    {
        Console.WriteLine("Enter a number you want to print a table of  ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number till which you want to print the table");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Multiplication Table of {0} to {1}", r, n);
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0} x {1} = {2} ", r, i, r * i);
        }
    }
}