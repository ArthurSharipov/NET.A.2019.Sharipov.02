using System;

namespace FindNewtonRoot
{
    public static class Find
    {
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
            //return (int)x2;
        }
    }
}
