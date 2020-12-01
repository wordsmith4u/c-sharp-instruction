using System;

namespace ch03_Rounding_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rounding and Formatting");

            double d1 = 55.321678;
            double d2 = Math.Round(d1, 2);
            double d3 = Math.Round(d1, 4);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //format d1 as US currency
            Console.WriteLine(d1.ToString("C"));


        }
    }
}
