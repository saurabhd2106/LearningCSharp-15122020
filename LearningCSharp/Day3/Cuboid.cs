using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Cuboid : Shape
    {
        public override double CalculateArea(int side)
        {
            double area = side * side;
            return area;
        }
    }
}
