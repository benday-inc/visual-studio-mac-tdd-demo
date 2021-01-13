using Benday.CalculatorDemo.Api;
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
            // arrange
            var systemUnderTest = new Calculator();
            int value1 = 2;
            int value2 = 3;
            int expected = -1;

            // act
            int actual = systemUnderTest.Subtract(value1, value2);

            // assert
            Assert.AreEqual<int>(expected, actual, "wrong value");
        }

        [TestMethod]
        public void Multiply()
        {
            // arrange
            var systemUnderTest = new Calculator();
            int value1 = 2;
            int value2 = 3;
            int expected = 6;

            // act
            int actual = systemUnderTest.Multiply(value1, value2);

            // assert
            Assert.AreEqual<int>(expected, actual, "wrong value");
        }

        [TestMethod]
        public void Divide()
        {
            // arrange
            var systemUnderTest = new Calculator();
            int value1 = 6;
            int value2 = 3;
            int expected = 2;

            // act
            int actual = systemUnderTest.Divide(value1, value2);

            // assert
            Assert.AreEqual<int>(expected, actual, "wrong value");
        }
    }

    [TestClass]
    public class PersonFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private Person _SystemUnderTest;

        private Person SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new Person();
                }

                return _SystemUnderTest;
            }
        }


    }
}









