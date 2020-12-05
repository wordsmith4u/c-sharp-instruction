using System;

namespace ch05_GuessingGame {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess The Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("I'm thinking of a number from 1 to 100.");
            Console.WriteLine("Try to guess it.");
            Console.WriteLine();

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter number: ");
                int randomNumber = new Random().Next(1, 100);
                static int GetGuess() {
                    int guess = 0;
                    try {
                        guess = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        Console.WriteLine("You did not enter a valid guess.");
                        guess = GetGuess();
                    }
                    return guess;
                }

       
                int numberOfTries = 0;
                while (true) {
                    int guess = GetGuess();
                    numberOfTries++;
                    if (guess == randomNumber) {
                        Console.WriteLine("You got it in " + numberOfTries + " tries.");
                        Console.WriteLine("Great work! You're a mathematical wizard!");
                        break;
                    }
                    if (guess > randomNumber) {
                        Console.WriteLine("Too high! Guess again.");
                    }
                    if (guess < randomNumber) {
                        Console.WriteLine("Too low! Guess again.");
                    }
                }
                    Console.WriteLine();
                    Console.Write("Continue? ");
                    choice = Console.ReadLine();
                }


                Console.WriteLine("Bye!");
            }
        }
    }





