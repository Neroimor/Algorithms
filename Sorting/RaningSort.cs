﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting
{
    internal class RaningSort
    {
        public RaningSort() {

           Runing().Wait();
            
        }

        private async Task Runing()
        {
            GeneratorArray generator = new GeneratorArray();

            Console.WriteLine("Sorted\n");

            await Task.Run(() =>
            {
                int[] array = generator.Generate(20, 100, 2);
                Console.WriteLine("Bubble Sorting\n");
                Stopwatch stopwatch = Stopwatch.StartNew();
                stopwatch.Start();
                ISorting<int> sorting = new BubbleSorting<int>();
                int[] sortedArray = sorting.Procces(array);
                PrintArray(sortedArray);
                Console.WriteLine();
                int[] reverseSortedArray = sorting.ReverseProcces(array);
                PrintArray(reverseSortedArray);
                stopwatch.Stop();
                Console.WriteLine($"\n{stopwatch.Elapsed}\n");

            });


            await Task.Run(() =>
            {
                int[] array = generator.Generate(20, 100, 2);
                Console.WriteLine("Selection Sorting\n");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ISorting<int> sorting = new SelectionSorting<int>();
                int[] sortedArray = sorting.Procces(array);
                PrintArray(array);
                Console.WriteLine();
                int[] reverseSortedArray = sorting.ReverseProcces(array);
                PrintArray(reverseSortedArray);
                stopwatch.Stop();
                Console.WriteLine($"\n{stopwatch.Elapsed}\n");

            });


            await Task.Run(() =>
            {
                int[] array = generator.Generate(20, 100, 2);
                Console.WriteLine("Insert Sorting\n");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ISorting<int> sorting = new InsertSorting<int>();
                int[] sortedArray = sorting.Procces(array);
                PrintArray(array);
                Console.WriteLine();
                int[] reverseSortedArray = sorting.ReverseProcces(array);
                PrintArray(reverseSortedArray);
                stopwatch.Stop();
                Console.WriteLine($"\n{stopwatch.Elapsed}\n");

            });



            await Task.Run(() =>
            {
                int[] array = generator.Generate(20, 100, 2);
                Console.WriteLine("Quick Sorting\n");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ISorting<int> sorting = new QuickSorting<int>();
                int[] sortedArray = sorting.Procces(array);
                PrintArray(array);
                Console.WriteLine();
                int[] reverseSortedArray = sorting.ReverseProcces(array);
                PrintArray(reverseSortedArray);
                stopwatch.Stop();
                Console.WriteLine($"\n{stopwatch.Elapsed}\n");

            });
        }
        void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
