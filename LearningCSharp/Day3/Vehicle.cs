using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Vehicle
    {
        public Vehicle()
        {

            Console.WriteLine("I am a constructor from Vehicle class with engine size - ");
        }

        public Vehicle(int engineSize)
        {
            this.EngineSize = engineSize;

            Console.WriteLine("I am a constructor from Vehicle class with engine size - " + engineSize);
        }

        public int EngineSize;

        public void StartEngine()
        {
            Console.WriteLine("Start Engine");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Stop Engine");
        }

    }
}
