using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class ListExample
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(12);
            list.Add(12);
            list.Add(12);
            list.Add(12);

            int[] arr = new int[6] { 9, 34, 6, 5, 98, 76 };

            list.AddRange(arr);

            Console.WriteLine(list[0]);

            list.Insert(0, 13);

            Console.WriteLine(list[0]);
        }
    }
}
