using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal class InsertSorting<T> : ISorting<T> where T : IComparable<T>
    {
        public T[] Procces(T[] arr)
        {
            T[] result = Sort(arr);
            return result;
        }

        public T[] ReverseProcces(T[] arr)
        {
            T[] result = ReversSort(arr);
            return result;
        }


        private T[] Sort(T[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j>=0 && IsGreaterThan(arr[j],key))
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }



            return arr;
        }

        private T[] ReversSort(T[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && IsLessThan(arr[j], key))
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }



            return arr;
        }

        private bool IsGreaterThan(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }

        private bool IsLessThan(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }
    }
}
