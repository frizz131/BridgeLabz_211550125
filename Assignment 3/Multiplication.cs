using System;

class Multiplication
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to find its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Multiplication table of " + number + " from 6 to 9:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
