using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTestTask.Tests
{
    [TestClass]
    public class GeometryMsTest
    {
        [TestMethod]
        public void CircleArea_ValidRadius()
        {

            double radius = 5;
            Assert.AreEqual(Math.PI * radius * radius, Geometry.CircleArea(radius));
        }

        [TestMethod]
        public void CircleArea_NegativeRadius()
        {

            double radius = -5;
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Geometry.CircleArea(radius);
            });
        }

        [TestMethod]
        public void CircleNull_NegativeRadius()
        {

            string radius = null;
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Geometry.CircleArea(radius);
            });
        }

        [TestMethod]
        public void CircleNull_NotConvertRadius()
        {

            string radius = "sdawq";
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Geometry.CircleArea(radius);
            });
        }

        [TestMethod]
        public void TriangleArea_ValidSides()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Assert.AreEqual(6, Geometry.TriangleArea(side1, side2, side3));
        }

        [TestMethod]
        public void IsRightTriangle_RightTriangle_ReturnsRightTriangleEnum()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Assert.AreEqual(EnumRightTriangle.RightTriangle, Geometry.IsRightTriangle(side1, side2, side3));
        }

        [TestMethod]
        public void IsRightTriangle_NotRightTriangle_ReturnsNotRightTriangleEnum()
        {
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;
            EnumRightTriangle result = Geometry.IsRightTriangle(side1, side2, side3);
            Assert.AreEqual(EnumRightTriangle.NotRightTriangle, result);
        }

    }
}