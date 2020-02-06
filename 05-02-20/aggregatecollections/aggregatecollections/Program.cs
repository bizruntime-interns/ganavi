using System;
using System.Collections.Generic;
using System.Linq;

namespace aggregatecollections
{
    class AggrregateSum
    {
        static void Main(string[] args)
        {
            var numList = new List<int>() {1,3,5,2 };
            Console.WriteLine("Sum:{0}", numList.Aggregate((a, b) => a + b));

            Console.WriteLine("Avg:{0}", numList.AsQueryable().Average());

            Console.WriteLine("All:{0}", numList.All(x=>x>3));
            Console.WriteLine("Any:{0}", numList.Any(x => x > 3));



            Console.ReadLine();
        }
    }
}
