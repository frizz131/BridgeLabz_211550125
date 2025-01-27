using System;

class FactorialProgram
{
    static void Main(string[] args)
    {
        //Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            
            long factorial = 1;
            int counter = number;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Output the result
            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
    }
}
