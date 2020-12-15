using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class Employee
    {
        private int salary;

        private int bonus;

        public int Salary { private get; set; }

        public int Bonus {
            get
            {
                return salary;
            }

            set
            {
                if(value > 0)
                {
                    salary = value;
                }

            }
        }


        //Read access
        public int GetSalary()
        {
            return salary;
        }


        //Write access
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }


        public Employee()
        {

            salary = 6000;
            bonus = 500;

        }

        public Employee(int Salary, int Bonus)
        {

            this.salary = Salary;

            this.bonus = Bonus;

        }

        public void CalculateSalary()
        {
            int totalSalary = salary + bonus;

            Console.WriteLine("Total Salary "+ totalSalary);
        }

        public int CalculateSalary1()
        {
            int totalSalary = salary + bonus;

            return totalSalary;
        }

        public void CalculateSalary(int salary, int bonus)
        {
            int totalSalary = salary + bonus;

            Console.WriteLine("Total Salary " + totalSalary);
        }

        public int CalculateSalary2(int Salary, int Bonus)
        {
            int totalSalary = Salary + this.bonus;

            Console.WriteLine("Total Salary " + totalSalary);

            return totalSalary;
        }
    }
}
