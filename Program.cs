using System;
using System.Numerics;

namespace TestApp3_11._7._21_CM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter the second number: ");
            string secondNumber = Console.ReadLine();

            try
            {
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + Multiply(firstNumber, secondNumber));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static string Multiply(string num1, string num2)
        {
            BigInteger firstNumber = TryParseBigInt(num1);

            BigInteger secondNumber = TryParseBigInt(num2);

            return (firstNumber * secondNumber).ToString();
        }

        private static BigInteger TryParseBigInt(string possibleNumber)
        {
            if (!BigInteger.TryParse(possibleNumber, out BigInteger actualNumber))
            {
                throw new Exception($"Attempted conversion of '{possibleNumber ?? " < null > "}' failed.");
            }

            return actualNumber;
        }
    }
}
