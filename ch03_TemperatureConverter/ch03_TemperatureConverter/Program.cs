using System;

namespace ch03_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine();

            double fahrenheit;
            double celsius;
            
            // while loop - 'continue' loop, similar to Java projects
            String choice = "y";
            while (choice.Equals("y"))
          {
                Console.Write("Enter degrees in fahrenheit: ");
                fahrenheit = int.Parse(Console.ReadLine());
                double d2 = Convert.ToDouble(fahrenheit);
                celsius = (fahrenheit - 32) * (0.5556);
                celsius = (double)Math.Round(celsius * 100) / 100;

                Console.WriteLine("Degrees in Celsius:" + celsius);
                Console.WriteLine();
                Console.Write("Continue? ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("Bye!");
        }
    }
}