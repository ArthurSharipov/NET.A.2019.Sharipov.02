using System;
using System.Text;

namespace FindBiggerNumber
{
    public class FindNumber
    {
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

        private void Swap(int[] items, int right, int left)
        {
            int temp = items[right];
            items[right] = items[left];
            items[left] = temp;
        }
    }
}
