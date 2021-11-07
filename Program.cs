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

            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + Multiply(firstNumber, secondNumber));
            Console.ReadKey();
        }

        public static string Multiply(string num1, string num2)
        {
            BigInteger firstNumber = BigInteger.Parse(num1);
            BigInteger secondNumber = BigInteger.Parse(num2);

            BigInteger finalNumber = (firstNumber * secondNumber);

            return finalNumber.ToString();
        }
    }
}
