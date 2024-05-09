namespace CalculatorTest
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
    }
}