using System;

namespace ch05_GuessingGame {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess The Number Game!");

            int randomNumber = new Random().Next(1, 101);
            int inputGuess;
            int countInputGuess = 0;
            Boolean userWin = false;

            void playGame() {
                while (countInputGuess != 7 && userWin != true) {
                    Console.WriteLine("\nPlease enter your guess between 1 and 100!");

                    countInputGuess++;

                    var userInput = Console.ReadLine();

                    if (validateInput(userInput)) {
                        Console.WriteLine(evaluateAnswer());
                    } else {
                        Console.WriteLine("Not a valid number!");
                    }
                }
            }

            Boolean validateInput(String userInput) {

                if (int.TryParse(userInput, out inputGuess)) {
                    return true;
                } else {
                    return false;
                }

            }

            String evaluateAnswer() {
                if (inputGuess == randomNumber) {
                    userWin = true;
                    return $"YOU WIN. The number is { randomNumber } and your inputGuess is { inputGuess } :) \n";
                } else if (countInputGuess == 7) {
                    return $"\nYou Lost! You have tried { countInputGuess } times with no luck :( Random Number is { randomNumber } \n";
                } else {
                    if (inputGuess < randomNumber) {
                        return $"Guess is too low! You have attempted { countInputGuess } times. \n";
                    } else {
                        return $"Guess is too high! You have attempted { countInputGuess } times. \n";
                    }
                }

                Boolean resetGame() {
                    Console.WriteLine("\nDo you want to play again? Y for yes");
                    userWin = false;
                    countInputGuess = 0;

                    if (Console.ReadKey().Key == ConsoleKey.Y) {
                        return true;
                    } else return false;
                    { }

                    while (resetGame()) {
                        playGame();
                        resetGame();

                    }
                }
            }
        }
    }
}
