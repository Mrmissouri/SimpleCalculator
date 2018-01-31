using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number to be added:");

            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number to be added:");

            int numTwo = int.Parse(Console.ReadLine());

            int answer = numOne + numTwo;

            Console.WriteLine("The answer is: " + answer);

            Console.ReadLine();
        }
    }
}
