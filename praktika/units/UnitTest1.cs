using NUnit.Framework;
using calculate;

namespace units
{
    public class Tests
    {
        [Test]
        public void PlusT()
        {
            double x = 10.3;
            double y = 7.7;
            double expected = 18;
            var plus = new Plus();
            double actual = plus.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestFixture]
        public class TestAddition
        {
            [TestCase(1, 1, 2)]
            [TestCase(2, 2, 4)]
            [TestCase(5, 12, 17)]
            public void CalcTest(double firstNum, double secondNum, double answer)
            {
                var addition = new Plus();
                double fullanswer = addition.Calculate(firstNum, secondNum);
                Assert.AreEqual(answer, fullanswer);
            }
        }
        [TestFixture]
        public class TestSubtraction
        {
            [TestCase(1, 1, 0)]
            [TestCase(2, 2, 0)]
            [TestCase(5, 12, -7)]

            public void CalcTest(double firstNum, double secondNum, double answer)
            {
                var subtraction = new minus();
                double fullanswer = subtraction.Calculate(firstNum, secondNum);
                Assert.AreEqual(answer, fullanswer);
            }

        }
        [TestFixture]
        public class Divisiontest
        {
            [TestCase(1, 1, 1)]
            [TestCase(6, 6, 1)]
            [TestCase(1000, 500, 2)]
            public void CalculateTest(double firstNum, double secondNum, double answer)
            {
                // actual result
                var division = new Div();
                double fullanswer = division.Calculate(firstNum, secondNum);
                ;
                Assert.AreEqual(answer, fullanswer);
            }
        }
        [TestFixture]
        public class Remaindertest
        {
            [TestCase(1, 1, 0)]
            [TestCase(5, 6, 5)]
            [TestCase(3, 2, 1)]
            public void CalculateTest(double firstNum, double secondNum, double answer)
            {
                // actual result
                var remainder = new Remainder();
                double fullanswer = remainder.Calculate(firstNum, secondNum);
                ;
                Assert.AreEqual(answer, fullanswer);
            }
        }
    }
}