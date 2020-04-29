using System;
using System.Collections.Generic;
using System.Text;

namespace Pascalator.Second
{
    public interface ICalculate
    {
        double LastResult { get; }
        bool IsOn { get; }
        void OnOff();
        void Clear();
        void Sum(double x, double y);
        void Sum(double y);
        void Subtract(double x, double y);
        void Subtract(double y);
        void Multiply(double x, double y);
        void Multiply(double y);
        void Divide(double x, double y);
        void Divide(double y);
        void Remainder(double x, double y);
        void Remainder(double y);
        void Min(double[] numbers);
        void Max(double[] numbers);
        void Average(double[] numbers);
        void AddPercentage(double value, double percentage);
        void AddPercentage(double percentage);
        void RemovePercentage(double value, double percentage);
        void RemovePercentage(double percentage);
        void GetSquareRoot(double value);
        void GetSquareRoot();
        void GetRoot(double value, double root);
        void GetRoot(double root);
        void Power(double value, double power);
        void Power(double power);
    }
}
