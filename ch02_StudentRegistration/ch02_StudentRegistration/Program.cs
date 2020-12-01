using DocuSign.eSign.Model;
using System;

namespace ch02_StudentRegistration
{
    class Program {
            static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();

            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            String lastName = Console.ReadLine();

            Console.Write("Enter Year of Birth: ");
            String birthYear = Console.ReadLine();

            Console.WriteLine("Welcome" + " " +  firstName + " " +  lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine();
            Console.WriteLine("Your temporary password is:" + " " + firstName + "*" + birthYear);
             }
        }
    }