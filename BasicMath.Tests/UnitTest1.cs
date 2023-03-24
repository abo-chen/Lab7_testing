using BasicMath;

namespace BasicMath.Tests
{
    [TestClass]
    public class BasicMathTests
    {
        private BasicMath _basicMath;

        [TestInitialize]
        public void Setup()
        {
            _basicMath = new BasicMath();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            double a = 5;
            double b = 7;
            double expectedSum = 12;

            double actualSum = _basicMath.Add(a, b);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Sub_TwoNumbers_ReturnsSum()
        {
            double a = 5;
            double b = 7;
            double expectedSum = -2;

            double actualSum = _basicMath.Subtract(a, b);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsSum()
        {
            double a = 5;
            double b = 7;
            double expectedSum = 35;

            double actualSum = _basicMath.Multiply(a, b);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsSum()
        {
            double a = 21;
            double b = 7;
            double expectedSum = 3;

            double actualSum = _basicMath.Divide(a, b);

            Assert.AreEqual(expectedSum, actualSum);
        }

    }
}