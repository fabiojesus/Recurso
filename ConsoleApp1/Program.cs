using Pascalator.First;
using Pascalator.Second;
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
            Calculator obj = new Calculator();
            int i = 0;
        }
    }
}
