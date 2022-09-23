using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 > 10 은 ");
            Console.WriteLine(10 > 10);

            Console.Write("10 >= 10 은 ");
            Console.WriteLine(10 >= 10);

            Console.Write("5 < 10 은 ");
            Console.WriteLine(5 < 10);

            Console.Write("5 <= 10 은 ");
            Console.WriteLine(5 <= 10);

            Console.Write("5 == 4 은 ");
            Console.WriteLine(5 == 4);

            Console.Write("5 != 4 은 ");
            Console.WriteLine(5 != 4);

            int number1 = 2;
            int userInput1 = 2;
            bool isSame = number1 == userInput1;
            Console.WriteLine(isSame);

        }
    }
}
