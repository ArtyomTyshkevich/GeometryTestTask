using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTestTask
{
    public interface IGeometry
    {
        public double CircleArea<T>(T radius);
        public double TriangleArea<T>(T side1, T side2, T side3);
        public EnumRightTriangle IsRightTriangle<T>(T side1, T side2, T side3);
    }
}
