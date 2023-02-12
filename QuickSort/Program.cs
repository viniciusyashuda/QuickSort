using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your array's length: ");
            var arrayLength = int.Parse(Console.ReadLine());

            var array = new int[arrayLength];

            for (int arrayElement = 0; arrayElement < arrayLength; arrayElement++)
            {
                Console.Write("Insert the element number " + (arrayElement + 1) + ": ");
                array[arrayElement] = int.Parse(Console.ReadLine());
            }

            QuickSort(array, 0, arrayLength - 1);

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(i == 0 ? "Ordered Array: [" : "");
                Console.Write(i != arrayLength - 1 ? $"{array[i]}, " : $"{array[i]}]");
            }

            Console.ReadKey();
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                    QuickSort(array, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(array, pivot + 1, right);
            }

        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            while (true)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (array[left] == array[right]) 
                        return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                    return right;
            }
        }
    }
}
