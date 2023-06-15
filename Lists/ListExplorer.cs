

using System;
using System.Collections;


 public  class ListExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists!");
            ArrayList theArrayList = new ArrayList();
            testArrayPerformance(theArrayList, 100000);

            LinkedList<int> theLinkedList = new LinkedList<int>();
            testListPerformance(theLinkedList, 100000);
        }

        private static void testListPerformance(LinkedList<int> numbers, int howMany){

            int startTime = Environment.TickCount;
            for (int i = 0; i < howMany; i++) {
                numbers.AddLast( i);
            }
            int endTime = Environment.TickCount;

            Console.WriteLine("Total execution time for {0} items is {1}ms: ",howMany , (endTime - startTime));

        }

        
        private static void testArrayPerformance(IList numbers, int howMany){

            int startTime = Environment.TickCount;
            for (int i = 0; i < howMany; i++) {
                numbers.Add( i);
            }
            int endTime = Environment.TickCount;

            Console.WriteLine("Total execution time for {0} items is {1}ms: ",howMany , (endTime - startTime));

        }


}