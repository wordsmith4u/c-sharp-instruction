using ch07_product_manager.Business;
using ch07_product_manager.util;
using System;

namespace ch07_product_manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager");

            Product p1 = new Product();
            p1.code = ".net";
            p1.description = "Murach's C# and .Net";
            p1.price = 58.99;
            Console.WriteLine ("p1 = " + p1);

            Product p2 = new Product("java", "Murach's Java Programming", 59.50);
            Console.WriteLine($"p2 = {p2}");

            string code = MyConsole.GetString("Enter product code: ");
            string desc = MyConsole.GetString("Enter product description: ");
            double price = MyConsole.getDouble("Enter product price: ");

            Product p3 = new Product(code, desc, price);



            Console.WriteLine("Bye");
        }
    }
}
