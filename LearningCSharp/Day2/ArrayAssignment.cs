using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class ArrayAssignment
    {
        static void Main(string[] args)
        {
            //Find max value out of an array
            int max = 0;

            int[] arr = new int[6] { 9, 34, 6, 5, 98, 76};

            foreach(int temp in arr)
            {
                if(temp> max)
                {
                    max = temp;
                }
            }

            Console.WriteLine($"Max value is {max}");


            //Let's say you have an array of size 10, value = 0, 1
            // Find the count of 0 and 1 in this array

            Random random = new Random();

            int[] arr2 = new int[20];

            for(int i =0; i< arr2.Length; i++)
            {
                arr2[i] = random.Next(2);

            }

            foreach (int temp in arr2)
            {
                Console.Write(temp + "    ");
            }

            int[] count = new int[2];
            
            foreach(int temp in arr2)
            {
                count[temp]++;
            }

            Console.WriteLine($"Count of 0 is {count[0]} and Count of 1 is {count[1]}");

            //Let's say you have an array of size 100, value = 0, 1, 2  ..... 9
            // Find the count of 0, 1, 2 ..... 9 in this array

            int[] arr3 = new int[100];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(10);

            }

            object[] objArray = new object[5];

            objArray[0] = "Saurabh";
            objArray[0] = true;
            objArray[0] = 45;
            objArray[0] = 45.8;
        }
    }
}
