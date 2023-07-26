using MindboxFigures;

namespace MindboxFiguresLibrary.Figures
{
    public class Triangle : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!IsTriangleValid(side1, side2, side3)) throw new ArgumentException("Треугольника с такими сторонами не может быть");
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double CalculateArea()
        {
            double p = (_side1 + _side2 + _side3) / 2;
            return Math.Round(Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3)), 2);
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _side1, _side2, _side3 };
            //Сортировка массива со сторонами по возрастанию
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        //Проверка на возможность существования треугольника
        private bool IsTriangleValid(double side1, double side2, double side3) => (side1 + side2 > side3) &&
                                                                                  (side1 + side3 > side2) &&
                                                                                  (side2 + side3 > side1);
    }
}
