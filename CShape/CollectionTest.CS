using System;
using System.Collections;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Queue  
            Queue myQ = new Queue();

            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount: {0}", myQ.Count);
            Console.Write("\tValues: ");

            PrintValues(myQ);

            // stack
            
            
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

