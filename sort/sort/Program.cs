using System;
using System.Diagnostics;
using System.IO;

namespace sort
{
    class Program
    {
        static void BubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min]) min = j;
                }
                (array[i], array[min]) = (array[min], array[i]);
            }
        }
        static void MergeSort(ref int[] array, int start, int end)
        {
            if (start + 1 == end) return;
            if (end - start == 2)
            {
                if (array[start] > array[start + 1])
                {
                    (array[start], array[start + 1]) = (array[start + 1], array[start]);
                }
                return;
            }
            var border = (end + start) / 2;
            MergeSort(ref array, start, border);
            MergeSort(ref array, border, end);
            var tempArray = new int[end - start];
            var i = start; 
            var j = border;
            for (int k = 0; k < end - start; k++)
            {
                if (i == border)
                {
                    tempArray[k] = array[j];
                    j++;
                    continue;
                }
                if (j == end)
                {
                    tempArray[k] = array[i];
                    i++;
                    continue;
                }
                tempArray[k] = Math.Min(array[i], array[j]);
                if (tempArray[k] == array[i]) i++;
                else j++;
                
            }

            int l = 0;
            for (int k = start; k < end; k++)
            {
                array[k] = tempArray[l];
                l++;
            }
        }
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            const int dimension = 1000000;
            var sr = new StreamReader("D:\\c#projects\\sort\\sort\\data.txt");
            var array = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                array[i] = int.Parse(sr.ReadLine());
            }
            sr.Close(); 
            MergeSort(ref array, 0, dimension);
            // Array.Sort(array);
            stopWatch.Stop();
            // BubbleSort(ref array);
            var sw = new StreamWriter("D:\\c#projects\\sort\\sort\\output.txt");
            foreach (var i in array)
            {
                sw.WriteLine(i);
            }
            sw.Close();
            var ts = stopWatch.Elapsed;
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}";
            Console.WriteLine($"Runtime {elapsedTime}");
        }
    }
}