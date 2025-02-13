using NUnit.Framework;
using TriangleSolver;

namespace Triangle_Unit_Test

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

        // 3 Tests for Zero-Length Sides
        [Test]
        public void InvalidTriangle_Input0and5and5_OutputInvalid()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 5;
            int thirdSide = 5;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTriangle_Input0and0and5_OutputInvalid()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 5;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTriangle_Input4and0and4_OutputInvalid()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 0;
            int thirdSide = 4;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // 3 Tests for Invalid Triangle (Other than Zero)
        [Test]
        public void InvalidTriangle_Input1and2and10_OutputInvalid()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 10;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTriangle_Input2and3and7_OutputInvalid()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 7;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTriangle_Input5and1and1_OutputInvalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 1;
            int thirdSide = 1;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
