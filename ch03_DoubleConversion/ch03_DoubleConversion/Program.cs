using System;

namespace ch03_double_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert a double!");
            Console.Write("Enter a decimal value:  ");
            String dStr = Console.ReadLine();
            double d1 = Double.Parse(dStr);
            double d2 = Convert.ToDouble(dStr);
        }
    }
}