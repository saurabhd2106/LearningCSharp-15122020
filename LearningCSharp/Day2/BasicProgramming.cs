using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class BasicProgramming
    {
        //Find Greatest out of two numbers
        // 1. firstNumber > secondNumber
        // 2. secondNumber > firstNumber
        // 3. Both are equal

        //Find Greatest out of three numbers
        // 1. firstNumber > secondNumber > thirdNumber
        // 2. secondNumber > firstNumber > thirdNumber
        // 3. All are equal
        // 4. thirdNumber > firstNumber > secondNumber
        // 5. firstNumber == secondNumber > thirdNumber
        // 6. 
        // 7. 

        static void Main(string[] args)
        {
            int firstNumber = 10;

            int secondNumber = 90;

            int thirdNumber = 89;

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                Console.WriteLine("First Number is greatest");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("Second Number is greatest");
            }
            else if ((secondNumber == firstNumber) && (firstNumber> thirdNumber))
            {
                Console.WriteLine("First Number and Second number are equal and are greater than third Number");
            }

            //--------------------------------------------------------------

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("First Number is greatest");
            }
            
            else if(secondNumber == firstNumber)
            {

            }
            else 
            {

            }

            //-------------------------------------------------------------------

            int dayOfTheWeek = 3;

            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thurday");
                    break;
                default:
                    Console.WriteLine( "Invalid Day");
                    break;
            }

            string dayOfTheWeekStr = "Monday";

            switch (dayOfTheWeekStr)
            {
                case "Monday":
                    Console.WriteLine("Monday");
                    break;
                
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }


        }
    }
}
