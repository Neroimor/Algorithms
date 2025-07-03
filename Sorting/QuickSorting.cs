using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal class QuickSorting<T> : ISorting<T> where T : IComparable<T>
    {
        public T[] Procces(T[] arr)
        {
            T[] result = Sorting(arr);


            return result;
        }

        private T[] Sorting(T[] arr)
        {
            StartQuick(arr,0,arr.Length-1);
            return arr;
        }


        private void StartQuick(T[] arr, int start, int end)
        {
            if (start<end)
            {
                int pivot = Partion(arr, start, end);
                StartQuick(arr, start, pivot-1);
                StartQuick(arr, pivot + 1, end);
            }

            
        }

        private int Partion(T[] arr, int start, int pivot)
        {
            int i = start;

            while (i<pivot)
            {
                if (IsGreaterThan(arr[i], arr[pivot]) && i == pivot-1)
                {
                    Swap(ref arr[i], ref arr[pivot]);
                    pivot--;
                }
                else if (IsGreaterThan(arr[i], arr[pivot]))
                {
                    Swap(ref arr[pivot-1], ref arr[pivot]);
                    Swap(ref arr[i], ref arr[pivot]);

                    pivot--;
                }
                else
                {
                    i++;
                }
            }

            return pivot;
        }


        public T[] ReverseProcces(T[] arr)
        {
            T[] result = RevSorting(arr);


            return result;
        }



        private T[] RevSorting(T[] arr)
        {
            RevStartQuick(arr, 0, arr.Length - 1);
            return arr;
        }


        private void RevStartQuick(T[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = RevPartion(arr, start, end);
                RevStartQuick(arr, start, pivot - 1);
                RevStartQuick(arr, pivot + 1, end);
            }


        }

        private int RevPartion(T[] arr, int start, int pivot)
        {
            int i = start;

            while (i < pivot)
            {
                if (IsLessThan(arr[i], arr[pivot]) && i == pivot - 1)
                {
                    Swap(ref arr[i], ref arr[pivot]);
                    pivot--;
                }
                else if (IsLessThan(arr[i], arr[pivot]))
                {
                    Swap(ref arr[pivot - 1], ref arr[pivot]);
                    Swap(ref arr[i], ref arr[pivot]);

                    pivot--;
                }
                else
                {
                    i++;
                }
            }

            return pivot;
        }

        private bool IsGreaterThan(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
        private bool IsLessThan(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        private void Swap(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
