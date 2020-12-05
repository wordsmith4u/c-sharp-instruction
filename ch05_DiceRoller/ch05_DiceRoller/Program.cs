using System;

namespace ch05_DiceRoller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();

            String choice = "y";
            while (choice.Equals("y")) {

                int dice1 = getDiceRoll();
                int dice2 = getDiceRoll();

                static int getDiceRoll() {
                    var r = new Random();
                    int diceRoll = r.Next(6) + 1;
                    return diceRoll;
                }

                static void printExtraMessage(int dice1, int dice2) {
                    if (dice1 + dice2 == 2) {
                        Console.WriteLine("Snake Eyes!");
                    } else if (dice1 + dice2 == 12) {
                        Console.WriteLine("Box Cars!");
                    }
                }

                String message = "Die 1: " + dice1 + "\nDie 2: " + dice2 + "\nTotal: " + (dice1 + dice2);
                printExtraMessage(dice1, dice2);

                Console.WriteLine(message);
                Console.Write("Continue? ");
                Console.WriteLine();
                choice = Console.ReadLine();
            }


            Console.WriteLine("Bye!");
        }
    }
}