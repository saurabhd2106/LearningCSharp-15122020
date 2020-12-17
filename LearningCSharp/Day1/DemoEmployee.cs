using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class DemoEmployee
    {
        static void Main(string[] args)
        {
            Employee saurabh;

            //Instantiate an object -- assigning memory location (heap memory)
            //Employee -- Constructor -- it assigns default value to the variable

            saurabh = new Employee(70000, 2835);

            saurabh.employeeId = 3247823;

            saurabh.Salary = 90000;
            saurabh.Bonus = 3247;

            int saurabhSalary = saurabh.Salary;

            Console.WriteLine(saurabhSalary);

            saurabh.CalculateSalary();
            saurabh.CalculateSalary(4000, 5000);

            Employee prem = new Employee();

            prem.Salary = 90000;
        }
    }
}
