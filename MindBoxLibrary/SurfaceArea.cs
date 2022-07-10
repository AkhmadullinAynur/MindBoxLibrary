namespace MindBoxLibrary
{
    public class SurfaceArea
    {
        public static double GetCircleArea(double radius)
        {
            return new Circle(radius).GetArea();
        }
        public static double GetTriangleArea(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }
    }
}
