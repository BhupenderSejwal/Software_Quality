using NUnit.Framework;
using TriangleSolver;

namespace Triangle_Unit_Test

// This is a test change for commit


{


    [TestFixture]
    public class TriangleTests
    {
        // 1. Test for a valid Equilateral Triangle
        [Test]
        public void ValidTriangle_Input5and5and5_OutputEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }

}