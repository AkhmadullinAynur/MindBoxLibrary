using MindBoxLibrary;
using MindBoxLibraryTests.Interfaces;
using System;
using Xunit;

namespace MindBoxLibraryTests
{
    public class TestTriangleArea: IAreaTest
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

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => SurfaceArea.GetTriangleArea(0, 1, 1));
            Assert.Throws<ArgumentException>(() => SurfaceArea.GetTriangleArea(1, 0, 1));
            Assert.Throws<ArgumentException>(() => SurfaceArea.GetTriangleArea(1, 1, 0));
        }

        [Fact]
        public void IsRightCorrect()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
            Assert.False(new Triangle(3, 3, 3).IsRight);
        }
    }
}
