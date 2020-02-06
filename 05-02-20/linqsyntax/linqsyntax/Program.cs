using System;
using System.Collections.Generic;
using System.Linq;

namespace linqsyntax
{
    class LinqSyntax
    {
        static void Main()
        {

            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            IEnumerable<int> highestScore = from score in scores
                                select scores.Max();
            foreach (int i in highestScore)
            {
                Console.WriteLine(i + "");
            }

        }
    }
}
