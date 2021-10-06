using System;

namespace Stackandqueues4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            #region UC4 Dequeue List
            Console.WriteLine("-----UC4-----");
            Console.WriteLine("enqued list:");
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            Console.WriteLine("\n------------");
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            #endregion

            Console.ReadKey();
        }
    }
}
