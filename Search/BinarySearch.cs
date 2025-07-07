using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Search
{
    internal class BinarySearch<T> : ISearch<T> where T : IComparable<T>
    {
        public int Search(T[] array, T value)
        {
            int index = IterativeBinSearch(array, value, 0, array.Length);
            int index2 = RecursionBinSearch(array, value, 0, array.Length);

            if (index == index2)
            {
                return index;
            }
            return -1;
        }

        private int RecursionBinSearch(T[] array, T Value, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (IsEqual(Value, middleValue))
            {
                return middle;
            }
            else
            {
                if (IsGreaterThan(Value, middleValue))
                {
                   return RecursionBinSearch(array, Value, middle + 1, last);
                }
                else
                {
                   return RecursionBinSearch(array, Value, first, middle - 1);
                }
            }


        }


        private int IterativeBinSearch(T[] array, T value, int left, int right)
        {

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (IsEqual(value, array[middle]))
                {
                    return middle;
                }
                else if (IsLessThan(value, array[middle]))
                {
                    right = middle - 1;
                }
                else if (IsGreaterThan(value, array[middle]))
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        private bool IsGreaterThan(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
        private bool IsLessThan(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }
        private bool IsEqual(T a, T b)
        {
            return a.CompareTo(b) == 0;
        }

    }
}
