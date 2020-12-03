using System;

namespace ch03_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop Example");
            // index for loop that will print "Hello" n times
            // n is an int entered by the user

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Hello! " + i);

            }
            Console.WriteLine("Bye");
        }
    }
}
