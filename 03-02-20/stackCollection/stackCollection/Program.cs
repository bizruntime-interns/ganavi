using System;
using System.Collections.Generic;



namespace stackCollection
{
    class StackCollection
    {
        static void Main(string[] args)
        {
            System.Collections.Stack stack = new System.Collections.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine("1 in Stack:{0}", stack.Contains(1));

            Console.WriteLine("Remove 1:{0}", stack.Pop());

            Console.WriteLine("Peek1:{0}", stack.Peek());

            object[] numArray = stack.ToArray();
            Console.WriteLine(string.Join(", ", numArray));
            foreach(object o in stack)
            {
                Console.WriteLine($"stack:{o}");
            }
        }
    }
}
