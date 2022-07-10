using MindBoxLibrary;
using Xunit;

namespace MindBoxLibraryTests
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsAreaCorrect()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6;
            double actual = SurfaceArea.GetTriangleArea(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}
