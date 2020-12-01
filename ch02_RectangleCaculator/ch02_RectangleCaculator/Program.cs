using System;

namespace ch02_RectangleCaculator
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the rectangle calculator!");

            String choice = "y";
            while (choice.Equals("y"))
            {
                int l, w, area, perimeter;
                Console.Write("Length : ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Width : ");
                w = Convert.ToInt32(Console.ReadLine());
                area = l * w;
                perimeter = 2 * (l + w);
                Console.WriteLine("Area of Rectangle : " + area);
                Console.WriteLine("Perimeter of Rectangle : " + perimeter);

                Console.Write("Continue? ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye!");
        }
    }
}