using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Search
{
    internal class RaningSearch
    {
        public RaningSearch()
        {
            Runing().Wait();
        }

        private async Task Runing()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 5;

            Task.Run(() =>
            {
                LinearSearch<int> linearSearch = new LinearSearch<int>();
                int result = linearSearch.Search(arr, target);
                Console.WriteLine($"Linear Search: Element {target} found at index {result}");
            }).Wait();


            Task.Run(() =>
            {
                BinarySearch<int> linearSearch = new BinarySearch<int>();
                int result = linearSearch.Search(arr, target);
                Console.WriteLine($"Binary Search: Element {target} found at index {result}");
            }).Wait();
        }
    }
}
