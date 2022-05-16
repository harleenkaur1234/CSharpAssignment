using System;
class Pattern
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < b; i++)
        {
            for (int j = b; j > i; j--)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}
