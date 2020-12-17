using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoVehicle
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(1200);

            vehicle.EngineSize = 1200;

            vehicle.StartEngine();

            vehicle.StopEngine();

            Console.WriteLine("------------------------------------------------------------------");

            Car alto = new Car(1231);

            alto.StartEngine();

            alto.StopEngine();

            alto.RestartEnine();

            alto.RunEngine();

            Console.WriteLine("------------------------------------------------------------------");

            Vehicle bmw = new Car(2300);

            bmw.EngineSize = 2900;

            bmw.StartEngine();

            bmw.StopEngine();

            Console.WriteLine("------------------------------------------------------------------");

           
        }
    }
}
