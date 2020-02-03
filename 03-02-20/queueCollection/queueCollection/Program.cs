using System;
using System.Collections.Generic;


namespace queueCollection
{
    class QueueCollection
    {
        static void Main(string[] args)
        {
            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue:{0}",queue.Contains(1));

            Console.WriteLine("Remove 1:{0}", queue.Dequeue());

            Console.WriteLine("Peek1:{0}", queue.Peek());

            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(", ", numArray));



        }
    }
}
