using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Car : Vehicle
    {
        public Car(int engineSize) : base(engineSize)
        {
            Console.WriteLine("I am a constructor from Car class");
        }

        public int HoursePower { get; set; }

        public void RestartEnine()
        {
            Console.WriteLine("Restart Enine");
        }

        public void RunEngine()
        {
            Console.WriteLine("Run Engine");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop Engine in Car Class");
        }
    }
}
