using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSelection_Sort
{
    internal class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int n=arr.Length;
            for(int i=0; i<n; i++)
            {
                int minIndex = i;
                for(int j=i+1; j<n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }

                }
                int temp = arr[i];
                arr[i]= arr[minIndex];
                arr[minIndex]= temp;
            }
        }
        public static void Print(int[] arr) {
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 11, 12, 34, 15, 23, 87, 35 };
            Console.WriteLine("Print Array Without Sort");
            Print(arr);
            SelectionSort(arr);
            Console.WriteLine("After Selection Sort");
            Print(arr);
            Console.ReadKey();
        }
    }
}
