using System;
using System.Linq;
using System.Threading;
using System.Xml.Schema;

namespace Arrays
{
    public static class CoisasECenas
    {
        /// <summary>
        /// Sums two numbers
        /// </summary>
        /// <param name="number1">The first number</param>
        /// <param name="number2">The second number</param>
        /// <returns>The sum of two numbers</returns>
        public static double Sum(double number1, double number2)
        {
            double sum = 0;
            sum = number1 + number2;
            return sum;
        }
        /// <summary>
        /// Subtracts based on the two numbers inserted
        /// </summary>
        /// <param name="number1">First number inserted</param>
        /// <param name="number2">Second number inserted</param>
        /// <returns>The substraction of two numbers</returns>

        public static double Subtract ( double number1, double number2)
        {
            double subtraction = 0;
            subtraction = number1 - number2;
            return subtraction;
        }
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="number1">The first number</param>
        /// <param name="number2">The second number</param>
        /// <returns>The division of two numbers</returns>
        public static double Divide (double number1, double number2)
        {
            double division = 0;
            if (number2 == 0)
            {
                return 0;
            }
            division = number1 / number2;
            return division;

        }
            /// <summary>
            /// Multiplication of two given numbers
            /// </summary>
            /// <param name="number1">First number</param>
            /// <param name="number2">Second number</param>
            /// <returns>Multiplication of said numbers</returns>
            public static double Multiplication(double number1, double number2)
            {
                double multiplication = number1 * number2;
                return multiplication;
            }

            /// <summary>
            /// Remainder of division between two numbers
            /// </summary>
            /// <param name="number1">First number</param>
            /// <param name="number2">Second number</param>
            /// <returns>Remainder of two numbers</returns>
            public static double Remainder(double number1, double number2)
            {
                double remainder = number1 % number2;
                return remainder;
            
            }

        /// <summary>
        /// Presents the min number of array
        /// </summary>
        /// <param name="numbers">Numbers array</param>
        /// <returns>Returns the min value of the array</returns> 
        public static int MinNumber(int[] numbers)
        { 
            int num = numbers[0]; 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (num > numbers[i])
                {
                    num = numbers[i];
                } 
            }
            return num;
        }

        /// <summary>
        /// Presents the greatest number of array
        /// </summary>
        /// <param name="numbers">Numbers array</param>
        /// <returns>Returns the biggest value of the array</returns> 
        public static int MaxNumber(int[] numbers)
        {
            int num = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (num < numbers[i])
                {
                    num = numbers[i];
                }
            }
            return num;
        }

        /// <summary>
        /// Determines number one to the power of number two
        /// </summary
        /// <param name="number1">The base number</param>
        /// <param name="number2">The exponent number</param>
        /// <returns>Powered number</returns>
        public static double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        /// <summary>
        /// Determine the average of an array
        /// </summary>
        /// <param name="numbers">The array of numbers</param>
        /// <returns>The average of all the numbers in the array</returns>
        public static int Average(int[] numbers)
        {
            int average = 0;

            for (int i = 0; i < numbers.Length; i++)
                average += numbers[i];

            return (average / numbers.Length);
        }
    }
}
