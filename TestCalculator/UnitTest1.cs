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
            float num1 = 5.5f;
            float num2 = 3.2f;
            float expected = 8.7f;

            float result = Calculator.Add(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSubtract()
        {
            float num1 = 55.5f;
            float num2 = 33.3f;
            float expected = 22.2f;
            float result = Calculator.Subtract(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivide()
        {
            float num1 = 6;
            float num2 = 0;
            float expected = 0;

            float result = Calculator.Divide(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMultiply()
        {
            float num1 = 5.5f;
            float num2 = 1;
            float expected = 5.5f;

            float result = Calculator.Multiply(num1, num2);

            Assert.AreEqual(expected, result);
        }
    }
}