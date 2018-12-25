using System;
using System.Collections;

/// <summary>
///  subject: some collection example (such Queue, Stack, LinkList)
///  data： 2018/12/25
///  source: copy from MSDN 
/// </summary>
namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue: FIFO 
            Queue myQ = new Queue();

            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount: {0}", myQ.Count);
            Console.Write("\tValues: ");

            PrintValues(myQ);

            // stack: LIFO
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Word");
            myStack.Push("!");

            Console.WriteLine("myStack");
            Console.WriteLine("\tCount: {0}", myStack.Count);
            Console.Write("\tValue:");
            PrintValues(myStack);
            
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write(" {0} ", obj);
            Console.WriteLine();
        }
    }
}

