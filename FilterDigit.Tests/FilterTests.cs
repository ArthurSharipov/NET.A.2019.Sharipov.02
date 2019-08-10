using FilterDigit;
using NUnit.Framework;

namespace FilterDigitTests
{
    public class FilterTests
    {
        [Test]
        [TestCase(7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, ExpectedResult = new int[] { 7, 70, 17 })]
        public static int[] FilterDigit(byte digit, params int[] array)
        {
            var filter = new Filter();
            return filter.FilterDigit(digit, array);
        }
    }
}