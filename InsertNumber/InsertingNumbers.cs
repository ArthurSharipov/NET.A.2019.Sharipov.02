using System;

namespace InsertNumber
{
    /// <summary>
    /// Insert number class.
    /// </summary>
    public class InsertingNumbers
    {
        /// <summary>
        /// Inserts bits from j-th to i-th bit one number to another.
        /// </summary>
        /// <param name="numberSource"></param>
        /// <param name="numberIn"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns>New number </returns>
        public int Insert(int numberSource, int numberIn, int i, int j)
        {
            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i > j)
            {
                throw new ArgumentException();
            }
            int medium = ((2 << (j - i)) - 1) << i;
            return (numberSource & ~medium) | ((numberIn << i) & medium);
        }
    }
}
