using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Pascalator.Second
{
    public static class DoubleExtensionMethods
    {
        public static double AddPercentage(this double value, double percentage)
        {
            return value * (percentage / 100 + 1);
        }

        public static double RemovePercentage(this double value, double percentage)
        {
            return value - (value * (percentage / 100));
        }

        public static double Average(this double[] numbers)
        {
            var total = 0.0;
            foreach (var num in numbers)
            {
                total += num;
            }
            return total / numbers.Length;
        }

        public static double Average(this List<double> numbers)
        {
            var total = 0.0;
            foreach (var num in numbers)
            {
                total += num;
            }
            return total / numbers.Count;
        }

        public static double Max(this double[] numbers)
        {
            var max = double.MinValue;
            foreach (var num in numbers)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public static double Max(this List<double> numbers)
        {
            var max = double.MinValue;
            foreach (var num in numbers)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public static double Min(this double[] numbers)
        {
            var min = double.MaxValue;
            foreach (var num in numbers)
            {
                if (num < min) min = num;
            }
            return min;
        }

        public static double Min(this List<double> numbers)
        {
            var min = double.MaxValue;
            foreach (var num in numbers)
            {
                if (num < min) min = num;
            }
            return min;
        }

    }
}
