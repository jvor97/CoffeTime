﻿using System;
using System.Collections.Concurrent;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 3, 5, 2, 10, 6, 7};
            quickSort(array, 0, array.Length - 1);
        }

        private static void quickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var pivot = partition(array, left, right);
                quickSort(array, left, pivot - 1);
                quickSort(array, pivot + 1, right);
            }
        }

        private static int partition(int[] array, int left, int right)
        {
            int pivot = array[right];

            int smaller = left - 1;
            int smallerRight = left;

            while (smallerRight < right)
            {
                if (array[smallerRight] <= pivot)
                {
                    smaller++;

                    swap(array, smaller, smallerRight);
                }

                smallerRight++;
            }

            swap(array, smaller + 1, right);

            return smaller + 1;
        }

        private static void swap(int[] array, int smaller, int smallerRight)
        {
            int temp = array[smaller];
            array[smaller] = array[smallerRight];
            array[smallerRight] = temp;
        }
    }
}