using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;

namespace FirstProgram
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 5, -7, 6, 3, 4 };
            int mediun = arr.Length/2;

            SelectionMaxMinSort(arr, 0, mediun);
            SelectionMinMaxSort(arr, mediun, arr.Length);
            foreach (int i in arr)
            {
                Debug.WriteLine(i);
            }
        }

        static void SelectionMinMaxSort(int[] arr, int startindex, int ednindex)
        {
          
            for (int i = startindex; i < ednindex; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < ednindex; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

        }
        static void SelectionMaxMinSort(int[] arr, int startindex, int ednindex)
        {
            for (int i = startindex; i < ednindex; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < ednindex; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[i];
                arr[i] = temp;
            }

        }

    }
}