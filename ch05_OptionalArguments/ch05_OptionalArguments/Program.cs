﻿using System;

namespace ch05_OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional Arguments!");
            int nb1 = 22;
            int nb2 = 44;
            int nb3 = 11;

            Console.WriteLine("Sum2 is: " + Sum(nb1, nb2));
            Console.WriteLine("Sum3 is: " + Sum(nb1, nb2, nb3));



            Console.WriteLine("Bye");
        }

        static int Sum(int n1, int n2, int n3 = 0)
        {
            return n1 + n2 + n3;
        }
    }
}
