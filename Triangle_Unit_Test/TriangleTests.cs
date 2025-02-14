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


        // 3 Tests for Valid Isosceles Triangle
        [Test]
        public void ValidTriangle_Input5and5and3_OutputIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 3;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input6and6and4_OutputIsosceles()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 6;
            int thirdSide = 4;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input7and10and7_OutputIsosceles()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 10;
            int thirdSide = 7;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // 5 Tests for Valid Scalene Triangle
        [Test]
        public void ValidTriangle_Input3and4and5_OutputScalene()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input8and6and7_OutputScalene()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 6;
            int thirdSide = 7;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input10and12and15_OutputScalene()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 12;
            int thirdSide = 15;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input9and14and16_OutputScalene()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 14;
            int thirdSide = 16;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input13and20and18_OutputScalene()
        {
            // Arrange
            int firstSide = 13;
            int secondSide = 20;
            int thirdSide = 18;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }

}


