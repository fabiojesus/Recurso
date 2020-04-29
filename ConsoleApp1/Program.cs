using Arrays;
using Pascaleira.Fase1;
using System;

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

            long i = 0;
            //var isBetween = i.IsBetween(10, 20);
            var firstIsBetween = i.IsBetweenAndDifferentFromAndDiviseableBy(10, 20, 8, 24);
            var secondIsBetween = i.IsBetweenAndDifferentFromAndDiviseableBy(18, 50, 31, 98);
            
            if(firstIsBetween)
            {
                char i = 'a';
                char.Is
                i = 3;
            }
            else
            {
                i = 4;
            }
            if (secondIsBetween)
            {
                i = 3;
            }
            else
            {
                i = 4;
            }

        }
    }
}
