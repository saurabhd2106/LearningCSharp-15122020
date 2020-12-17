using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class EnumExample
    {
        public enum BrowserType
        {
            chrome = 1,
            firefox = 2,
            edge = 3
        }


        static void Main(string[] args)
        {
            var browser = BrowserType.edge;

            Console.WriteLine((int) browser);
        }
    }
}
