using System;
using System.Collections;
using System.Collections.Generic;


namespace dictionaryCollection
{
    class DictCollections
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> heroes = new Dictionary<string, string>();
            heroes.Add("clark ket", "superman");
            heroes.Add("barry west", "batman");
            heroes.Add("abc def", "cap");

            heroes.Remove("clark ket");

            Console.WriteLine("Count:{0}",heroes.Count);
            Console.WriteLine("clark ket:{0}", heroes.ContainsKey("clark ket"));

            heroes.TryGetValue("clark kent", out string test);
            Console.WriteLine($"clark kent:{test}");

            foreach (KeyValuePair<string, string> item in heroes)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            heroes.Clear();


        }
    }
}
