using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Search
{
    internal interface ISearch<T>  where T : IComparable<T>
    {

        public int Search(T[] array, T value);
    }
}
