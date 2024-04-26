using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryTestTask
{
    public static class Geometry
    {
            public static double CircleArea<T>(T radius)
            {              
                double r=CircleСheck(radius);
                return Math.PI * r * r;
            }

            public static double TriangleArea<T>(T side1, T side2, T side3)
            {
                double[] sides = TrangleCheck(side1, side2, side3);
                double s = (sides[0] + sides[1] + sides[2]) / 2;
                return Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            }
            //можно вместо методов CircleArea, TriangleArea реализовать Area с 2 перегрузками и разным количеством аргументов, но тогда при добавлении
            //например квадрата, который будет принимать 1 аргумент так же как и круг, придется добавлять или дополнительный аргумент(string figure), 
            //или реализовать метод который будет уточнять какую именно фигуру вы имеете ввиду
            public static EnumRightTriangle IsRightTriangle<T>(T side1, T side2, T side3)
            {
               
                double[] sides = TrangleCheck(side1, side2, side3);
                Array.Sort(sides);

                if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                    return EnumRightTriangle.RightTriangle;
                else
                    return EnumRightTriangle.NotRightTriangle;
            }
            private static double CircleСheck<T>(T radius)
            {
                double r;
                if (radius == null)
                    throw new ArgumentNullException("Радиус не может быть null.");
                if (!double.TryParse(radius.ToString(), out r) || r < 0)
                    throw new ArgumentException("Радиус должен быть числом и больше или равным нулю.");
                return r;
            }
            private static double[] TrangleCheck<T>(T side1, T side2, T side3)
            {
                double[] sides =new double[3];
                if (side1 == null || side2 == null || side3 == null)
                    throw new ArgumentNullException("Сторона не может быть null.");
                if (!double.TryParse(side1.ToString(), out sides[0]) || !double.TryParse(side2.ToString(), out sides[1]) ||
                    !double.TryParse(side3.ToString(), out sides[2]) || sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
                    throw new ArgumentException("Длины сторон должны быть числами и больше нуля.");
                return sides;
            }
    }
}