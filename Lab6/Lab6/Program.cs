using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 2, 3, 4, 5, -1, -2, -3, -4 };
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            Deleter deleter = new Deleter();
            List<int> resultArray = deleter.Delete(array);
            foreach (int element in resultArray)
            {
                Console.Write($"{element} ");
            }
            Console.Read();
        }
    }
}
