using System;
using System.Collections.Generic;
using System.Text;

namespace Pascalator.First
{
    public class Calculator : ICalculate
    {
        public double LastResult { get; private set; }

        public void AddPercentage(double value, double percentage)
        {
            LastResult = value * (percentage / 100 + 1);
        }

        public void Average(double[] numbers)
        {
            var total = 0.0;
            foreach(var num in numbers)
            {
                total += num;
            }
            LastResult = total / numbers.Length;
        }

        public void Divide(double x, double y)
        {
            LastResult = x / y;
        }

        public void GetRoot(double value, double root)
        {
            LastResult = Math.Pow(value, (1 / root));
        }

        public void GetSquareRoot(double value)
        {
            LastResult = Math.Pow(value, (1 / 2)); 
        }

        public void Max(double[] numbers)
        {
            var max = double.MinValue;
            foreach(var num in numbers)
            {
                if (num > max) max = num;
            }
            LastResult = max;
        }

        public void Min(double[] numbers)
        {
            var min = double.MaxValue;
            foreach(var num in numbers)
            {
                if (num < min) min = num;
            }
            LastResult = min;
        }

        public void Multiply(double x, double y)
        {
            LastResult = x * y;
        }

        public void Remainder(double x, double y)
        {
            LastResult = x % y;
        }

        public void RemovePercentage(double value, double percentage)
        {
            LastResult = value - (value * (percentage / 100));
        }

        public void Subtract(double x, double y)
        {
            LastResult = x - y;
        }

        public void Sum(double x, double y)
        {
            LastResult = x + y;
        }
    }
}
