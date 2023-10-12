using System;

namespace AliSalmeh_ProjectWeek9_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            bool playAgain;

            do
            {
                Console.Clear();

                var calculator = GetUserInputs();
                Calculator.PrintOperandOptions();

                string operand = Console.ReadLine();

                try
                {
                    if (operand == "/" && calculator.SecondNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    result = calculator.Process(operand);
                    Console.WriteLine($"Result: {calculator.FirstNumber} {operand} {calculator.SecondNumber} = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Message: " + ex.Message);
                }

                playAgain = calculator.GetPlayAgainInput();
            } while (playAgain);

            Console.WriteLine("Bye!");
        }

        public static Calculator GetUserInputs()
        {
            Console.WriteLine("------------------\n" +
                                "Calculator Program\n" +
                                "------------------");

            Console.Write("Enter first number: ");
            var number1 = GetDoubleInputs();

            Console.Write("Enter second number: ");
            var number2 = GetDoubleInputs();

            return new Calculator(number1, number2);
        }

        private static double GetDoubleInputs()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return input;
        }
    }
}
