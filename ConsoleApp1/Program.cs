using Pascalator.First;
using System;
using System.Linq;

namespace ConsoleApp1
{

    public static class ExtensionMethods
    {
        public static bool IsBetweenAndDifferentFromAndDiviseableBy(this long i, long min, long max, long different, long divisor)
        {
            return i > min && i < max && i != different && i % divisor == 0;
        }
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            var max = double.MaxValue;
            var calc = new Calculator();
            calc.Sum(1, 2);
            Console.WriteLine(calc.LastResult);
        }
    }
}
