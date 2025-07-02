// See https://aka.ms/new-console-template for more information
using Algorithm;
using Algorithm.Sorting;
using System.Diagnostics;

Console.WriteLine("Original\n");
GeneratorArray generator = new GeneratorArray();
int[] array = generator.Generate(20, 100, 2);
foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n\nSorted\n");

await Task.Run(() =>
{
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

void PrintArray<T>(T[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}