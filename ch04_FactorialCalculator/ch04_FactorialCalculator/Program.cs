using System;
using System.Net;
public class FactorialExample
{
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to the factorial calculator app!");
        Console.WriteLine();

        String choice = "y";
        while (choice.Equals("y"))
        {
            int i, fact = 1, number;
        Console.Write("Enter an integer that's greater than 0 and less than 10: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.Write("The Factorial of " + number + " is: " + fact);
            Console.WriteLine();
        Console.Write("Continue? ");
        choice = Console.ReadLine();
    }


    Console.WriteLine("Bye!");
        }
    }

