using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal interface ISorting<T>
    {
        public T[] Procces(T[] arr);
        public T[] ReverseProcces(T[] arr);
    }
}
