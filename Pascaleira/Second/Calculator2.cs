using System;
using System.Collections.Generic;

namespace Pascalator.Second
{
    public class Calculator : ICalculate
    {

        public double LastResult { get; private set; }

        public bool IsOn { get; private set; }

        public void AddPercentage(double value, double percentage)
        {
            if (!IsOn) return;
            LastResult = value.AddPercentage(percentage);
        }

        public void AddPercentage(double percentage)
        {
            AddPercentage(LastResult, percentage);
        }

        public void Average(double[] numbers)
        {
            if (!IsOn) return;
            LastResult = numbers.Average();
        }

        public void Average(List<double> numbers)
        {
            if (!IsOn) return;
            LastResult = numbers.Average();
        }

        public void Clear()
        {
            LastResult = 0.0;
        }

        public void Divide(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x / y;
        }

        public void Divide(double y)
        {
            Divide(LastResult, y);
        }

        public void GetRoot(double value, double root)
        {
            if (!IsOn) return;
            LastResult = Math.Pow(value, (1 / root));
        }

        public void GetRoot(double root)
        {
            GetRoot(LastResult, root);
        }

        public void GetSquareRoot(double value)
        {
            GetRoot(value, 2);
        }

        public void GetSquareRoot()
        {
            GetSquareRoot(LastResult);
        }

        public void Max(double[] numbers)
        {
            if (!IsOn) return;
            LastResult = numbers.Max();
        }

        public void Min(double[] numbers)
        {
            if (!IsOn) return;
            LastResult = numbers.Min();
        }

        public void Multiply(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x*y;
        }

        public void Multiply(double y)
        {
            Multiply(LastResult, y);
        }

        public void OnOff()
        {
            IsOn = !IsOn;
            Clear();
        }

        public void Power(double value, double power)
        {
           if(!IsOn) return;
            LastResult = Math.Pow(value, power);
        }

        public void Power(double power)
        {
            Power(LastResult, power);
        }

        public void Remainder(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x % y;
        }

        public void Remainder(double y)
        {
            Remainder(LastResult, y);
        }

        public void RemovePercentage(double value, double percentage)
        {
            if (!IsOn) return;
            LastResult = value.RemovePercentage(percentage);
        }

        public void RemovePercentage(double percentage)
        {
            RemovePercentage(LastResult, percentage);
        }

        public void Subtract(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x - y;
        }

        public void Subtract(double y)
        {
            Subtract(LastResult, y);
        }

        public void Sum(double x, double y)
        {
            if (!IsOn) return;
            LastResult = x + y;
        }

        public void Sum(double y)
        {
            Sum(LastResult, y);
        }
    }
}
