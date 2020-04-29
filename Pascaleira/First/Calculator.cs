using System;
using System.Collections.Generic;
using System.Text;

namespace Pascalator.First
{
    public class Calculator : ICalculate
    {
        public double LastResult { get; private set; }

        public bool IsOn { get; private set; }

        public void Clean()
        {
            LastResult = 0.0;
        }

        public void OnOff()
        {
            IsOn = !IsOn;
            if (!IsOn) Clean();
        }

        public void AddPercentage(double value, double percentage)
        {
            if (!IsOn) return;
            LastResult = value * (percentage / 100 + 1);
        }

        public void Average(double[] numbers)
        {
            if (!IsOn) return;
            var total = 0.0;
            foreach (var num in numbers)
            {
                total += num;
            }
            LastResult = total / numbers.Length;
        }

        public void Divide(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x / y;
        }

        public void GetRoot(double value, double root)
        {
            if (!IsOn) return;
            LastResult = Math.Pow(value, (1 / root));
        }

        public void GetSquareRoot(double value)
        {
            if (!IsOn) return;
            LastResult = Math.Pow(value, (1 / 2)); 
        }

        public void Max(double[] numbers)
        {
            if (!IsOn) return;
            var max = double.MinValue;
            foreach(var num in numbers)
            {
                if (num > max) max = num;
            }
            LastResult = max;
        }

        public void Min(double[] numbers)
        {
            if (!IsOn) return;
            var min = double.MaxValue;
            foreach(var num in numbers)
            {
                if (num < min) min = num;
            }
            LastResult = min;
        }

        public void Multiply(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x * y;
        }

        public void Remainder(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x % y;
        }

        public void RemovePercentage(double value, double percentage)
        {
            if (!IsOn) return;
            LastResult = value - (value * (percentage / 100));
        }

        public void Subtract(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x - y;
        }

        public void Sum(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x + y;
        }

        public static double Soma(double x, double y)
        {
            return x + y;
        }
    }
}
