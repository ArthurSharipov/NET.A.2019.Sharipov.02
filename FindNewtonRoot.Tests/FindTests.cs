using NUnit.Framework;
using System;

namespace FindNewtonRoot.Tests
{
    public class FindTests
    {
        //[Test]
        //[TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        //[TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        //[TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        //[TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        //[TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        //[TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        //public double FindNthRoot(double number, double degree, double accuracy)
        //{
        //    return Find.FindNthRoot(number, degree, accuracy);
        //}

        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        public void FindNthRoot(double number, int degree, double accuracy, double expectedResult) 
            => Assert.AreEqual(Find.FindNthRoot(number, degree, accuracy), expectedResult, accuracy);
    }
}