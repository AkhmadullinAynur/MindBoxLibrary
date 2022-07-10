using MindBoxLibrary.Interfaces;
using System;
using System.Linq;


namespace MindBoxLibrary
{
    public class Triangle : ISerfaceArea
    {
        readonly double[] _lengths;

        public Triangle(double a, double b, double c)
        {
            _lengths[0] = a;
            _lengths[1] = b;
            _lengths[2] = c;
        }

        public double GetArea()
        {
            double p = _lengths.Sum() / 2;
            return Math.Sqrt(p * (p - _lengths[0]) * (p - _lengths[1]) * (p - _lengths[2]));
        }
    }
}
