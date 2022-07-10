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
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("All sides of the triangle must be greater than 0!");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("The radius of the circle must be a number!");
            }
            if (Double.IsNaN(a) || Double.IsNaN(b) || Double.IsNaN(c))
            {
                throw new ArgumentException("The side of the triangle must be a number!");
            }
            _lengths = new double[3] { a, b, c };
        }

        public double GetArea()
        {
            double p = _lengths.Sum() / 2;
            return Math.Sqrt(p * (p - _lengths[0]) * (p - _lengths[1]) * (p - _lengths[2]));
        }

        public bool IsRight
        {
            get
            {
                Array.Sort(_lengths);
                return Math.Pow(_lengths[0], 2) + Math.Pow(_lengths[1], 2) == Math.Pow(_lengths[2], 2);
            }
        }
    }
}
