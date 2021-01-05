using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Benday.CalculatorDemo.UnitTests
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestMethod]
        public void Add()
        {
            // arrange
            var systemUnderTest = new Calculator();
            int value1 = 2;
            int value2 = 3;
            int expected = 5;

            // act
            int actual = systemUnderTest.Add(value1, value2);

            // assert
            Assert.AreEqual<int>(expected, actual, "wrong value");
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Divide()
        {
            Assert.Inconclusive();
        }
    }
}









