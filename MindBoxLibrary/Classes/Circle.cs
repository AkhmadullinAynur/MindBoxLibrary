using MindBoxLibrary.Interfaces;
using System;

namespace MindBoxLibrary
{
    public class Circle : ISerfaceArea
    {
        readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius of the circle cannot be less than 0!");
            }
            if (Double.IsNaN(radius))
            {
                throw new ArgumentException("The radius of the circle must be a number!");
            }
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
