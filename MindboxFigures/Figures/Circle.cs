using MindboxFigures;

namespace MindboxFiguresLibrary.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (!IsCircleValid(radius)) throw new ArgumentException("Круг с таким радиусом не может существовать");
            _radius = radius;
        }

        //Вычисление площади
        public override double CalculateArea() => Math.Round(Math.PI * _radius * _radius, 2);

        //Проверка на возможность существования круга
        private bool IsCircleValid(double radius) => radius > 0;
    }
}
