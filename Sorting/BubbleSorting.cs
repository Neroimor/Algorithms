using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal class BubbleSorting<T> : ISorting<T> where T : IComparable<T>
    {
        public T[] Procces(T[] array)
        {
            T[] result = Sort(array);

            return result;
        }
        public T[] ReverseProcces(T[] arr)
        {
            T[] result = ReverseSort(arr);
            return result;
        }

        private T[] Sort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (IsGreaterThan(array[j], array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }

                }
                if (!swapped)
                {
                    break;
                }
            }

            return array;
        }

        private T[] ReverseSort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (IsLessThan(array[j], array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return array;
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

        private void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


    }
}
