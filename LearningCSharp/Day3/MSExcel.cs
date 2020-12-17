using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class MSExcel : IMsProduct, Office365
    {
        public void New()
        {
            Console.WriteLine("New Method from MSExcel");
        }

        public void Print()
        {
            Console.WriteLine("Print statement from MSExcel");
        }

        public void Save()
        {
            Console.WriteLine("Save statement from MSExcel");
        }

        public void SaveAs()
        {
            Console.WriteLine("Save as statement from MSExcel");
        }

        public void Close()
        {
            Console.WriteLine("Close statement from MSExcel");
        }

        public void UpdateFile()
        {
            Console.WriteLine("Update statement from MSExcel");
        }
    }
}
