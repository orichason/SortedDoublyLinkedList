using System;

namespace SortedDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int> sortedList = new SortedList<int>();

            Random gen = new Random(1);

            for (int i = 0; i < 10; i++)
            {
                int randonNumber = gen.Next(100);
                //Console.WriteLine($"inserting a {randonNumber}");
                sortedList.Insert(randonNumber);
            }

            sortedList.Print();

            gen = new Random(1);

            //for (int i = 0; i < 5; i++)
            //{
            //    int randomNumber = gen.Next(100);
            //    sortedList.Delete(randomNumber);
                
            //}

            sortedList.Print();

            ;
        }
    }
}
