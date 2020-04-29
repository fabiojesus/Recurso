using System;
using System.Data;
using System.Threading;
using System.Xml.Schema;

namespace Pascaleira.Base
{
    public static class Pascalator
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

        public static double Subtract(double number1, double number2)
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
        public static double Divide(double number1, double number2)
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

        /// <summary>f
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
        /// <returns>Returns the lesser value of the array</returns> 
        public static int Min(int[] numbers)
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
        /// <returns>Returns the greatest value of the array</returns> 
        public static int Max(int[] numbers)
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
        /// <summary>
        /// add a percentage value 
        /// </summary>
        /// <param name="num">Base number</param>
        /// <param name="perc"> value percetagem</param>
        /// <returns>num + value percetagem</returns>
        public static double AddPercentage(double num, double perc)
        {
            return num * (perc / 100 + 1);
        }
        /// <summary>
        /// subtracts a percentage to a number
        /// </summary>
        /// <param name="num">number</param>
        /// <param name="perc">percentage to subtract</param>
        /// <returns>the result</returns>
        public static double SubtractPercentage(double num, double perc)
        {
            var result = num - (num * (perc / 100));
            return result;
        }

        /// <summary>
        /// Gets Square Root
        /// </summary>
        /// <param name="number">number to which you want to apply square root</param>
        /// <returns>returns square root</returns>
        public static double GetSquareRoot(double number)
        {
            return Math.Pow(number, 1 / 2);

        }

        /// <summary>
        /// calculates the root of a number in the desiered power
        /// </summary>
        /// <param name="number">number to calculate the root</param>
        /// <param name="power">power in which to calculate the root</param>
        /// <returns>the calculated root</returns>c
        public static double GetRoot(double number, double power)
        {
            return Math.Pow(number, 1 / power);
        }
    }
}
