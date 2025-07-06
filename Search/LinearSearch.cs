using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Search
{
    internal class LinearSearch<T> : ISearch<T> where T : IComparable<T>
    {

        
    

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

        public int Search(T[] array, T value)
        {

            for (int i = 0; i < array.Length; i++) {

                if (IsEqual(value, array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
