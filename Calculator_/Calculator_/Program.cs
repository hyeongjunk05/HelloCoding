﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("연산자를 입력하세요.");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");

            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }

        }
    }
}
