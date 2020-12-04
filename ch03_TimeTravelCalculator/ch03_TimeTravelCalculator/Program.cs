using System;

namespace ch03_TimeTravelCalculator
{
    class Program
    {
        private const int V = 60;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Time Travel Calculator");
            Console.WriteLine();

            double miles = 0;
            double mph = 0;
            int MINS_PER_HOUR = V;

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter Miles: ");
                miles = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Miles Per Hour: ");
                mph = int.Parse(Console.ReadLine());
                Console.WriteLine("Estimated Travel Time: ");

                double hours = miles / mph;
                hours = (int)Math.Round(hours * 100) / 100;

                double miles_left = miles % mph;
                double minutes = miles_left % MINS_PER_HOUR;
                minutes = (int)Math.Round(minutes * 100) / 100;
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minutes);

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("Bye!");
        }
    }
}



    
