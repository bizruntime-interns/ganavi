using System;
using System.Collections.Generic;

namespace generic_collectionSum
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name = "No Name")
        {
            Name = name;

        }
        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX}+{dblY}={dblX + dblY}");

            int x = 5, y = 4;
            Animal.GetSum(ref x, ref y);

            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);
            Console.ReadLine();
        }
    }
}
       



