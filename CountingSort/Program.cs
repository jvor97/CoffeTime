﻿using System;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 1, 2, 7, 5, 2};
            countingSort(array);
        }

        private static int[] countingSort(int[] array)
        {
            var max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            var countedArray = new int[max + 1];

            for (int i = 0; i < array.Length; i++)
            {
                var numberIndex = array[i];
                countedArray[numberIndex] += 1;
            }

            for (int i = 0; i < countedArray.Length - 1; i++)
            {
                countedArray[i + 1] = countedArray[i] + countedArray[i + 1];
            }

            var sortedArray = new int[array.Length];

            for (int i = 0; i < sortedArray.Length; i++)
            {
                var numberIndex = array[i];
                var number = countedArray[numberIndex];
                countedArray[numberIndex] -= 1;
                sortedArray[number - 1] = array[i];
            }

            return sortedArray;
        }
    }
}