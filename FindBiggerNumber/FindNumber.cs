using System;
using System.Text;

namespace FindBiggerNumber
{
    /// <summary>
    /// Find bigger number class.
    /// </summary>
    public class FindNumber
    {
        /// <summary>
        /// Method that gets a number and returns bigger number consisting of the numbers of the source number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Next bigger number</returns>
        public int FindNextBiggerNumber(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number <= 11)
            {

                return -1;
            }

            int[] items = new int[number.ToString().Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = int.Parse(number.ToString()[i].ToString());
            }

            for (int i = items.Length - 1; i >= 0; i--)
            {
                if (items[i] > items[i - 1])
                {
                    Swap(items, i, i - 1);
                    break;
                }
                return -1;
            }

            foreach (int i in items)
            {
                stringBuilder.Append(i);
            }

            return int.Parse(stringBuilder.ToString());
        }

        /// <summary>
        /// Takes an array and rearranges the values ​​of the array in accordance with the passed parameters.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="right"></param>
        /// <param name="left"></param>
        private void Swap(int[] items, int right, int left)
        {
            int temp = items[right];
            items[right] = items[left];
            items[left] = temp;
        }
    }
}
