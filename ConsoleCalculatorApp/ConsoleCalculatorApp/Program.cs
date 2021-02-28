using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            double number1 = double.Parse(input[0]);
            double number2 = double.Parse(input[1]);
            string _operator = input[2];

            double result = Calculator(number1, number2, _operator);
            Console.WriteLine($"{number1} {_operator} {number2} = {result}");
        }

        private static double Calculator(double number1, double number2, string _operator)
        {
            double result = 0.0;
            switch (_operator)
            {
                
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "/":
                    result = Divide(number1, number2);
                    break;
                case "+":
                    result = Add(number1, number2);
                    break;
                case "-":
                    result = Subtract(number1, number2);
                    break;
            }
            return result;
        }

        private static double Subtract(double number1, double number2)
        {
            throw new NotImplementedException();
        }

        private static double Add(double number1, double number2)
        {
            double sum = number1 + number2;
            return sum;
        }

        private static double Divide(double number1, double number2)
        {
            double divide = 0.0;
            if (number2==0)
            {
               throw new Exception("Cannot divide by zero");
            }

            else

            {
                divide = number1 / number2;
            }

            return divide;
        }

        private static double Multiply(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }
}
