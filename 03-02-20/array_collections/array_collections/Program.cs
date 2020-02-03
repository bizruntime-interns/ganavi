using System;
using System.Collections;
using System.Collections.Generic;


namespace array_collections
{
    class CollectionArray
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Bob");
            a1.Add("20");

            Console.WriteLine("Count:{0}", a1.Count);

            Console.WriteLine("Capacity:{0}", a1.Capacity);

            ArrayList a2 = new ArrayList();
            a2.AddRange(new object[] { "mike", "Sally", "jkj" });
            a1.AddRange(a2);
            a2.Sort();
            a2.Reverse();

            a2.Insert(1, "turkey");
            ArrayList range = a2.GetRange(0, 2);
            foreach (object o in range)
            {
                Console.WriteLine(o);
            }
            a2.RemoveAt(0);
            a2.RemoveRange(0, 2);

            Console.WriteLine("turkey Index:{0}", a2.IndexOf("turkey", 0));
            string[] myArray = (string[])
                a2.ToArray(typeof(string));

            string[] customer = { "bob", "sally", "sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customer);

            foreach(string s in custArrayList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
