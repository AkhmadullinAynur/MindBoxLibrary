using MindBoxLibrary;
using System;
using Xunit;

namespace MindBoxLibraryTests
{
    public class TestCircleArea
    {
        [Fact]
        public void IsAreaCorrect()
        {
            double r = 1;
            double expected = Math.PI;
            double actual = SurfaceArea.GetCircleArea(r);
            Assert.Equal(expected, actual);
        }
    }
}
