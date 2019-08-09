using System;

namespace InsertNumber
{
    public class InsertingNumbers
    {
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
