using MindBoxLibrary.Interfaces;
using System;

namespace MindBoxLibrary
{
    public class Circle : ISerfaceArea
    {
        readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
