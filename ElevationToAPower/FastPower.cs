using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ElevationToAPower
{
    internal class FastPower<T> : IPower<T> where T : INumber<T>, IComparable<T>
    {
        public T Pow(T a, int n)
        {
            T a1 = RecursiveProcess(a, n);
            T a2 = IterativeProcess(a, n);
            if (IsEquals(a1, a2))
            {
                return RecursiveProcess(a, n);
            }
            throw new InvalidOperationException("The iterative and recursive methods returned different results.");
        }


        private bool IsEquals(T a, T b)
        {
            return a.CompareTo(b)==0;
        }

        private T RecursiveProcess(T a, int n)
        {
            if (n == 0)
                return T.One;


            if (n % 2 == 0)
            {
                T half = RecursiveProcess(a, n / 2);
                return half * half;
            }
   
            else
            {
                return a * RecursiveProcess(a, n - 1);
            }
        }


        private T IterativeProcess(T a, int n)
        {
            T result = T.One;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    a *= a;
                    n /= 2;
                }
                else
                {
                    result *= a;
                    n--;
                }
            }
            return result;
        }
    }
}
