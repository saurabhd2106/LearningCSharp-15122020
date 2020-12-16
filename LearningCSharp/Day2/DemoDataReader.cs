using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class DemoDataReader
    {
        static void Main(string[] args)
        {
            DataReader<string> dataReader = new DataReader<string>();

            dataReader.Data = "Saurabh";

            DataReader<int> intDataReader = new DataReader<int>();

            intDataReader.Data = 12;
        }
    }
}
