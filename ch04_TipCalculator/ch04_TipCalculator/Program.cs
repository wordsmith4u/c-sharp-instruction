using java.math;
using System;

namespace ch04_TipCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tip Calculator");
			Console.WriteLine();

			BigDecimal tip1 = new BigDecimal(.15);
			BigDecimal tip2 = new BigDecimal(.20);
			BigDecimal tip3 = new BigDecimal(.25);
			String choice = "y";
			while (choice.Equals("y"))
			{
				Console.WriteLine("Cost of Meal: ");
				BigDecimal mealCost = new BigDecimal(Console.ReadLine());
				Console.WriteLine();

				BigDecimal tipAmount1 = mealCost.multiply(tip1).setScale(2, RoundingMode.HALF_UP);
				BigDecimal tipAmount2 = mealCost.multiply(tip2).setScale(2, RoundingMode.HALF_UP);
				BigDecimal tipAmount3 = mealCost.multiply(tip3).setScale(2, RoundingMode.HALF_UP);

				Console.WriteLine("15%\r" + "Tip Amount:    " + "$" + (tipAmount1) + "\r" + "Total Amount:  " + "$"
						+ mealCost.add(tipAmount1));
				Console.WriteLine();
				Console.WriteLine("20%\r" + "Tip Amount:    " + "$" + (tipAmount2) + "\r" + "Total Amount:  " + "$"
						+ mealCost.add(tipAmount2));
				Console.WriteLine();
				Console.WriteLine("25%\r" + "Tip Amount:    " + "$" + (tipAmount3) + "\r" + "Total Amount:  " + "$"
						+ mealCost.add(tipAmount3));
				Console.WriteLine();

				Console.Write("Continue? ");
				choice = Console.ReadLine();
			}


			Console.WriteLine("Bye!");
		}
	}
}
