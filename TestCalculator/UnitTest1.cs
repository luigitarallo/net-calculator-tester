using net_calculator_tester;
namespace TestCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            float num1 = 5;
            float num2 = 3;
            float expected = 8;

            float result = Calculator.Add(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSubtract()
        {
            float num1 = 5;
            float num2 = 3;
            float expected = 2;
            float result = Calculator.Subtract(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivide()
        {
            float num1 = 6;
            float num2 = 2;
            float expected = 3;

            float result = Calculator.Divide(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMultiply()
        {
            float num1 = 5;
            float num2 = 4;
            float expected = 20;

            float result = Calculator.Multiply(num1, num2);

            Assert.AreEqual(expected, result);
        }
    }
}