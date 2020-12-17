using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoShape
    {
        static void Main(string[] args)
        {

            Cuboid cuboid = new Cuboid();

            double volumeOfCuboid = cuboid.CalculateVolume(10, 15);

            Console.WriteLine(volumeOfCuboid);

            Cylinder Cylinder = new Cylinder();

            double volumeOfCylinder = Cylinder.CalculateVolume(10, 10);

            Console.WriteLine(volumeOfCylinder);
        }
    }
}
