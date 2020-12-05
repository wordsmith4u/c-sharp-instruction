using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChocolate {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine(MakeChocolate(4, 1, 9).ToString()); //SHOULD RETURN 4
            Console.WriteLine(MakeChocolate(4, 1, 10).ToString()); //SHOULD RETURN -1
            Console.WriteLine(MakeChocolate(4, 1, 7).ToString()); //SHOULD RETURN 2
        }

        public static int MakeChocolate(int small, int big, int goal) {
            //5 kilo big bar
            //1 kilo small bar
            int bigBar = 5;
            int smallBar = 1;
            //Check what our goal is and get the number of big bars
            int bigGoal = goal / bigBar;
            int smallGoal = 0;

            //If our goal is bigger than our big we need to get the difference and times by the bigBar kilo(5)
            if (bigGoal > big) {
                smallGoal = (bigGoal - big) * bigBar;
            }

            //Our goal is however many are remaining from the bigBar (5)
            smallGoal += goal % bigBar;

            //It's not possible
            if (smallGoal > small) {
                return -1;
            }

            return smallGoal;

        }
    }
}