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
        static void ChangeSelection(int[] arr, int starindex, int endindex, bool reverce) 
        {
            if (reverce)
            {
                SelectionMaxMinSort(arr, starindex, endindex);
            }
            else
            {
                SelectionMaxMinSort(arr, starindex, endindex);
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