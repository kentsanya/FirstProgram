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
            int[] arr = { 5, -7, 6, 3, 4, 5, 6, 7, 8, 5, 7, 8, 8 };

           // 17/3=5, 0..5 5..10 10..17
            int separator = arr.Length / 3;
            ChangeSelection(arr, 0, separator, false);
            ChangeSelection(arr, separator, separator + separator, true);
            foreach (int i in arr)
            {
                Debug.WriteLine(i);
            }
        }

        static void ChangeSelection(int[] arr, int starindex, int endindex, bool reverce)
        {
            if (!reverce)
            {
                SelectionMinMaxSort(arr, starindex, endindex);
            }
            else
            {
                SelectionMaxMinSort(arr, starindex, endindex);
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