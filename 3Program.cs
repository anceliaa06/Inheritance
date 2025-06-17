using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num % 2 == 0 ? "Even number" : "Odd number");
    }
}
