using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoMSProduct
    {
        static void Main(string[] args)
        {
            MSExcel excel = new MSExcel();

            excel.New();

            excel.Close();

            //-----------------------------------

            IMsProduct msExcel = new MSExcel();

            msExcel.New();

            //Type Casting 


        }
    }
}
