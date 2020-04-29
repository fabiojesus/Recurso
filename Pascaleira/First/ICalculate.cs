using System;
using System.Collections.Generic;
using System.Text;

namespace Pascalator.First
{
    public interface ICalculate
    {
        void TakeBatteries();
        double LastResult { get; }
        void Sum(double x, double y);
        void Subtract(double x, double y);
        void Multiply(double x, double y);
        void Divide(double x, double y);
        void Remainder(double x, double y);
        void Min(double[] numbers);
        void Max(double[] numbers);
        void Average(double[] numbers);
        void AddPercentage(double value, double percentage);
        void RemovePercentage(double value, double percentage);
        void GetSquareRoot(double value);
        void Power(double value, double power);
        void GetRoot(double value, double root);
    }
}
