using System;
using System.Collections.Generic;
using System.Linq;

namespace linqdelegate
{
    class Program
    {
        delegate double doubleIt(double val);
        
        static void Main(string[] args)
        {
            doubleIt dblit = x => x * 2;
            Console.WriteLine($"5*2 = {dblit(5)}");

            List<int> numList = new List<int> { 1, 9, 3, 4, 8,2,5};
            var evenList = numList.Where(a =>a % 2 == 0).ToList();
            foreach (var j in evenList)
                Console.WriteLine(j);

            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach (var j in evenList)
                Console.WriteLine(j);
            Console.Read();

        }
    }
}
