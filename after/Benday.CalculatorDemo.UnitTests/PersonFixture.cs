using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Benday.CalculatorDemo.UnitTests
{
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









