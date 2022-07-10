using MindBoxLibrary;
using MindBoxLibraryTests.Interfaces;
using System;
using Xunit;

namespace MindBoxLibraryTests
{
    public class TestCircleArea: IAreaTest
    {
        [Fact]
        public void IsAreaCorrect()
        {
            double r = 1;
            double expected = Math.PI;
            double actual = SurfaceArea.GetCircleArea(r);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => SurfaceArea.GetCircleArea(0));
        }
    }
}
