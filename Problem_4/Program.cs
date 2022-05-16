using System;
public class Problem4
{
    public static int AddNumber(int number)
    {

        int m, sum = 0;
        while (number > 0)
        {
            m = number % 10;
            sum = sum + m;
            number /= 10;
        }
        return sum;
    }
    public static void Main()
    {
        Console.Write("Enter a number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of the digits of the number {0} is {1} ", a, AddNumber(a));
    }
}