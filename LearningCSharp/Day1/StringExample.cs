using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    class StringExample
    {
        static void Main(string[] args)
        {
            string str = "   My name is Saurabh   ";

            Console.WriteLine("Length of string " +str.Length);

            str = str.Trim();

            Console.WriteLine("Length of string " + str.Length);

            Console.WriteLine(str.ToLower());

            Console.WriteLine(str.ToUpper());

            Console.WriteLine(str.Contains("Saurabh"));

            Console.WriteLine(str.StartsWith("Her"));

            //String Interpolation

            string name = "Saurabh";

            int employeeId = 347434;

            string statement = String.Format("Name : {0} and EmployeeId {1}", name, employeeId);

            Console.WriteLine(statement);

            Console.WriteLine("Name : {0} and EmployeeId {1}", name, employeeId);

            string statement2 = $"Name : {name} and employee id is {employeeId}";

            Console.WriteLine($"Name : {name} and employee id is {employeeId}");
        }
    }
}
