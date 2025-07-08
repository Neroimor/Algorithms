using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ElevationToAPower
{
    internal class StandardPower<T> : IPower<T> where T : INumber<T>
    {
        public T Pow(T a, int n)
        {
            if (n == 0) return T.One;
            return Process(a, n);
        }

        private T Process(T a, int n)
        {

            
          T value = a;
            for (int i = 0; i < n-1; i++)
            {
                value*= a;
            }

            return value;
        }
    }
}
