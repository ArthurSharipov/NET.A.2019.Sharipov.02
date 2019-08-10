using FindBiggerNumber;
using NUnit.Framework;

namespace FindBiggerNumberTests
{
    public class FindNumberTests
    {
        [Test]
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = -1)]
        [TestCase(1234312, ExpectedResult = 1234321)]
        public int FindNextBiggerNumber(int number)
        {
            var findNumber = new FindNumber();
            return findNumber.FindNextBiggerNumber(number);
        }
    }
}