using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek9_Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public Calculator(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public static void PrintOperandOptions()
        {
            Console.WriteLine("Options:\n" +
                                "\t+ : Add\n" +
                                "\t- : Subtract\n" +
                                "\t* : Multiply\n" +
                                "\t/ : Divide");

            Console.Write("Enter an operand: ");
        }

        public double Process(string operand)
        {
            switch (operand)
            {
                case "+":
                    return FirstNumber + SecondNumber;
                case "-":
                    return FirstNumber - SecondNumber;
                case "*":
                    return FirstNumber * SecondNumber;
                case "/":
                    return FirstNumber / SecondNumber;
                default:
                    throw new Exception("You entered invalid operand!");
            }
        }

        public bool GetPlayAgainInput()
        {
            while (true)
            {
                Console.WriteLine("Would you like continue? (Y = yes, N = no): ");
                var play = Console.ReadLine().ToUpper();

                if (play == "Y")
                {
                    return true;
                }
                else if (play == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You entered invalid character!!\n\tTRY AGAIN:");
                }
            }
        }
    }
}