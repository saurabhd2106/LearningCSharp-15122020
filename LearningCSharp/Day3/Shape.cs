using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public abstract class Shape
    {
        public double CalculateVolume(int side, int height)
        {

            double volume = CalculateArea(side) * height;

            return volume;

        }

        public abstract double CalculateArea(int side);
    }
}
