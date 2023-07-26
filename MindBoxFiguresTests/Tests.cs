using MindboxFiguresLibrary.Figures;
using NUnit.Framework;

namespace MindBoxFiguresTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircle_Creation()
        {
            //Arrange
            double radius1 = 5;
            double radius2 = 5.5;
            double radius3 = -5;

            // Act & Assert
            // Assert
            //Можно создать
            Assert.DoesNotThrow(() => new Circle(radius1));
            Assert.DoesNotThrow(() => new Circle(radius2));
            //Нельзя создать
            Assert.Throws<ArgumentException>(() => new Circle(radius3));
        }

        [Test]
        public void TestCircle_CalculateArea()
        {
            //Arrange
            double radius = 5.5;
            double expectedS = 95.03;

            // Act & Assert
            // Assert
            Assert.That(() => new Circle(radius).CalculateArea(), Is.EqualTo(expectedS));
        }

        [Test]
        public void TestTriangle_Creation()
        {
            //Arrange
            double a = 3;
            double b = 6;
            double c = 4;
            double c1 = -3;

            // Act & Assert
            // Assert
            //Можно создать
            Assert.DoesNotThrow(() => new Triangle(a, b, c));
            //Нельзя создать
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c1));
        }

        [Test]
        public void TestTriangle_RightTriangle()
        {
            //Arrange
            double a = 3;
            double b = 5;
            double c = 4;
            double c1 = 4.5;

            var triangle1 = new Triangle(a, b, c);
            var triangle2 = new Triangle(a, b, c1);

            // Act & Assert
            // Assert
            //Прямоугольный
            Assert.IsTrue(triangle1.IsRightTriangle());
            //Не прямоугольный
            Assert.IsFalse(triangle2.IsRightTriangle());
        }

        [Test]
        public void TestTriangle_CalculateArea()
        {
            //Arrange
            double a = 4;
            double b = 5;
            double c = 8;
            double expectedS = 8.18;

            // Act & Assert
            // Assert
            Assert.That(() => new Triangle(a, b, c).CalculateArea(), Is.EqualTo(expectedS));
        }
    }
}
