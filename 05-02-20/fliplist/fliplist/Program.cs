using System;
using System.Collections.Generic;
using System.Linq;

namespace fliplist
{
    class LinqFliplist
    {
        static void Main(string[] args)
        {
            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while(i<100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;

            }
            Console.WriteLine("heads:{0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("tails:{0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string> {"dog", "cat","monkey"};
            var sNameList = nameList.Where(x => x.StartsWith("c"));
            foreach (var m in sNameList)
                Console.WriteLine(m);


        }
    }
}
