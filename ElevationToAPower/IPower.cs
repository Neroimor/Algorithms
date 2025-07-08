using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ElevationToAPower
{
    internal interface IPower<T>
    {

        public T Pow(T a, int n);
    }
}
