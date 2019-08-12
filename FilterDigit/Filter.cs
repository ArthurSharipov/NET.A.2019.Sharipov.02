using System;
using System.Collections.Generic;

namespace FilterDigit
{
    /// <summary>
    /// Filter class
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Method that gets array, filter it and return new array of filtered symbols.
        /// </summary>
        /// <param name="digit"></param>
        /// <param name="array"></param>
        /// <returns>Filtered array</returns>
        public int[] FilterDigit(byte digit, params int[] array)
        {
            var filtered = new List<int>();

            if (digit < 0 || digit > 9 || array.Length == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (var number in array)
            {
                if (ContainsDigit(number))
                {
                    filtered.Add(number);
                }
            }

            bool ContainsDigit(int number)
            {
                while (number > 0)
                {
                    if (number % 10 == digit)
                        return true;
                    number /= 10;
                }
                return false;
            }

            return filtered.ToArray();
        }
    }
}
