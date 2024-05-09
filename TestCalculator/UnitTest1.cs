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

            Assert.AreEqual(8.7f, Calculator.Add(num1, num2));
            Assert.AreEqual(10.7f, Calculator.Add(num1, 5.2f));
            Assert.AreEqual(-2f, Calculator.Add(-7.5f, 5.5f));
        }

        [Test]
        public void TestSubtract()
        {
            float num1 = 55.5f;
            float num2 = 33.3f;

            Assert.AreEqual(22.2f, Calculator.Subtract(num1, num2));
            Assert.AreEqual(20.3f, Calculator.Subtract(num1, 35.2f));
            Assert.AreEqual(-5.5f, Calculator.Subtract(0, 5.5f));
        }

        [Test]
        public void TestDivide()
        {
            float num1 = 6;
            float num2 = 3;

            Assert.AreEqual(2, Calculator.Divide(num1, num2));
            Assert.AreEqual(0.5f, Calculator.Divide(num2, num1));
            Assert.AreEqual(3, Calculator.Divide(num1, 2));
        }

        [Test]
        public void TestMultiply()
        {
            float num1 = 5.5f;
            float num2 = 2;

            Assert.AreEqual(11, Calculator.Multiply(num1, num2));
            Assert.AreEqual(16.5f, Calculator.Multiply(num1, 3));
        }
    }
}