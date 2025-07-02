using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal class SelectionSorting<T> : ISorting<T> where T : IComparable<T>
    {
        public T[] Procces(T[] arr)
        {
            T[] result = Sort(arr);
            return result;
        }

        private T[] Sort(T[] arr)
        {
            T min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = FindMinimumIndex(arr,i);
                Swap(ref arr[i], ref arr[minIndex]);
            }
         


            return arr;
        }

        private int FindMinimumIndex(T[] arr, int startPosition) {
            int minIndex = startPosition;
            T min = arr[startPosition];
            for (int i = startPosition; i < arr.Length; i++)
            {
                if (IsLessThan(arr[i],min))
                {
                    min = arr[i];
                    minIndex = i;
               
                }
            }
            return minIndex;


        }
        public T[] ReverseProcces(T[] arr)
        {
            T[] result = ReverseSort(arr);
            return result;
        }


        private T[] ReverseSort(T[] arr)
        {
            T min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = FindMaximumIndex(arr, i);
                Swap(ref arr[i], ref arr[minIndex]);
            }



            return arr;
        }
        private int FindMaximumIndex(T[] arr, int startPosition)
        {
            int minIndex = startPosition;
            T min = arr[startPosition];
            for (int i = startPosition; i < arr.Length; i++)
            {
                if (IsGreaterThen(arr[i], min))
                {
                    min = arr[i];
                    minIndex = i;

                }
            }
            return minIndex;


        }

        private bool IsGreaterThen(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
        private bool IsLessThan(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        private void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


    }
    
   
}
