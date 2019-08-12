using System;

namespace FindNewtonRoot
{
    /// <summary>
    /// Find n-th root class.
    /// </summary>
    public static class Find
    {
        /// <summary>
        /// The method calculates the root of the nth degree from a number using the Newton method with a given accuracy.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="degree"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public static double FindNthRoot(double number, double degree, double accuracy)
        {
            if (number <= 0 || degree <= 0)
                throw new ArgumentException();
            if (accuracy <= 0 || accuracy >= 1)
                throw new ArgumentOutOfRangeException();

            double x1 = number / degree;
            double x2 = 1.0 / degree * ((degree - 1) * x1 + number / Math.Pow(x1, degree - 1));
            while (Math.Abs(x1 - x2) > accuracy)
            {
                x1 = x2;
                x2 = 1.0 / degree * ((degree - 1) * x1 + number / Math.Pow(x1, degree - 1));
            }
            return x2;
        }
    }
}
