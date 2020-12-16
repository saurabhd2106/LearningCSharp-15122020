using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class ArrayExample
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 78;
            arr[1] = 48;
            arr[2] = 38;
            arr[3] = 76;
            arr[4] = 72;

            Console.WriteLine(arr[3]);

            //-------------------------------------------

            Console.WriteLine("******FOR EACH STARTS**********");
            foreach (int temp in arr)
            {
                
                Console.WriteLine(temp);

                
            }
            Console.WriteLine("******FOR EACH ENDS**********");
            Console.WriteLine("----------------------------------------");

            int[] arr1 = new int[5] { 67, 78, 87, 98, 12};

            for( int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("----------------------------------------");

            int count = 0;
            while(count < 5)
            {
                Console.WriteLine(arr[count]);

                count++;
            }

            Console.WriteLine("----------------------------------------");
            int counter = 5;

            do
            {
                Console.WriteLine($"Counter : " + counter);

            } while (counter < 5);



        }
    }
}
