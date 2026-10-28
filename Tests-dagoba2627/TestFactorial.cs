using TDD_dagoba2627;

namespace Tests_dagoba2627
{
    [TestClass]
    public sealed class TestFactorial
    {
        [TestMethod]
        public void testFactorialReturnsNegativeOneIfParameterIsLowerThanZero()
        {
            Assert.AreEqual(-1, Factorial.CalculateFactorial(-4));
        }

        [TestMethod]
        public void testFactorialReturnsOneIfParameterIsZero()
        {
            Assert.AreEqual(1, Factorial.CalculateFactorial(0));
        }

        [TestMethod]
        [DataRow(1,1)]
        [DataRow(2,2)]
        [DataRow(3,6)]
        [DataRow(10, 3628800)]
        public void testFactorialReturnsExpectedValueForPositiveValues(int n, int expected)
        {
            Assert.AreEqual(expected, Factorial.CalculateFactorial(n));
        }
    }
}
