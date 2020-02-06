using System;
using System.Collections.Generic;
using System.Linq;

namespace selectzip
{
    class CollectionSelect
    {
        static void Main(string[] args)
        {
            var one = new List<int>();
            one.AddRange(Enumerable.Range(1, 10));

            var squares = one.Select(x => x * x);
            foreach (var l in squares)
                Console.WriteLine(l);


            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 2, 4, 6 };
            var sumList = list1.Zip(list2, (x, y) => x + y).ToList();
            foreach (var n in sumList)
                Console.WriteLine(n);
            
        }
    }
}
