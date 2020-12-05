using ch07_product_manager.util;
using System;

namespace pig_dice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Pig Dice!");
            Console.WriteLine("Each game consists of die rolls until a 1 is rolled.");
            Console.WriteLine("You can play as many games as you like to try to reach the highest score.");
            int n = MyConsole.getInt("\nHow many games would you like to play?");
            int max = 0;
            for (int i = 0; i < n; i++) {
                int roll = 0;
                int total = 0;
                while (roll != 1) {
                    Random rand = new Random();
                    roll = rand.Next(1, 7);
                    total += roll;
                }
                //Console.WriteLine("Game #" + i + " score: " + total);
                max = Math.Max(max, total);
                roll = 0;
                total = 0;
            }
            Console.WriteLine("====================");
            Console.WriteLine("Total games:\t" + n);
            Console.WriteLine("Max Score:\t" + max);
            Console.WriteLine("====================");
            // other ideas
            // store # of rolls for max score?
        }
    }
}
