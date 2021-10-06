using System;

namespace Stackandqueues3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC3 Enqueue- Creat queue
            Console.WriteLine("-----UC3-----");
            Queue_UC3_UC4 queue = new Queue_UC3_UC4();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");

        }
    }

        }
   
