

using System;
using System.Collections;


 public  class ListExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists!");
            ArrayList theArrayList = new ArrayList();
            testArrayPerformance(theArrayList, 10000);

            LinkedList<int> theLinkedList = new LinkedList<int>();
            testListPerformance(theLinkedList, 10000);
        }

        private static void testListPerformance(LinkedList<int> numbers, int howMany){

            int startTime = Environment.TickCount;
            Random r = new Random();
            
            for (int i = 0; i < howMany; i++) {
                int rInt = r.Next(0, howMany/2);
                numbers.AddLast( rInt );
                numbers.Find(rInt);
            }
            int endTime = Environment.TickCount;

            Console.WriteLine("List execution time for {0} items is {1}ms: ",howMany , (endTime - startTime));

        }

        
        private static void testArrayPerformance(ArrayList numbers, int howMany){

            int startTime = Environment.TickCount;

            Random r = new Random();
            for (int i = 0; i < howMany; i++) {
                int rInt = r.Next(0, howMany/2);
                numbers.Add( rInt);
                numbers.Contains(rInt);
            }
            int endTime = Environment.TickCount;

            Console.WriteLine("Array execution time for {0} items is {1}ms: ",howMany , (endTime - startTime));

        }


}