using NUnit.Framework;

namespace InsertNumber.Tests
{
    public class InsertingNumbersTests
    {
        [Test]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertTest(int numberSource, int numberIn, int i, int j)
        {
            var insertingNumbers = new InsertingNumbers();
            return insertingNumbers.Insert(numberSource, numberIn, i, j);
        }
    }
}