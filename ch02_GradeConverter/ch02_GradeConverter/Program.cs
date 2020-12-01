using System;

namespace ch02_GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the letter grade converter!");

            // while loop - 'continue' loop, similar to Java projects
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter numerical grade: ");
                int numericalGrade = int.Parse(Console.ReadLine());
                String letterGrade = "";
                if (numericalGrade >= 88)
                {
                    letterGrade = "A";
                }
                else if (numericalGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (numericalGrade >= 67)
                {
                    letterGrade = "C";
                }
                else if (numericalGrade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                
                Console.Write("Letter Grade: " + letterGrade);
                Console.WriteLine();

                Console.Write("Continue? ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("Bye!");
        }
    }
}
