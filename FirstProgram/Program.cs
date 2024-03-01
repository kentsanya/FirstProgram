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
            int[] arr = { 5, -7, 3, 5, 4 };
            int mediun;
            if (arr.Length % 2 == 0)
            {
                mediun = arr.Length / 2;
            }
            else
            {
                mediun = arr.Length / 2 + 1;
            }
            SortBubleMaxMin(arr, 1, mediun);
            SortBubleMinMax(arr, mediun + 1, arr.Length);
            
            foreach (int i in arr)
            {
                Debug.WriteLine(i);
            }
        }
        static void SortBubleMinMax(int[] arr, int startindex, int endindex)
        {
            for (int i = startindex; i < endindex; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    int buble = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = buble;
                }
            }
        }
        static void SortBubleMaxMin(int[] arr, int startindex, int endindex)
        {
            for (int i = startindex; i < endindex; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    int buble = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = buble;
                }
            }
        }

        //static void SelectionMinMaxSort(int[] arr) 
        //{
        //    int count = arr.Length;
        //    for (int i = 0; i < count; i++) 
        //    {
        //        int minIndex = i;
        //        for (int j = i + 1; j < count; j++) 
        //        {
        //            if (arr[j] < arr[minIndex]) 
        //            {
        //                minIndex = j;
        //            }
        //        }
        //        int temp = arr[minIndex];
        //        arr[minIndex] = arr[i];
        //        arr[i] = temp;
        //    }

        //}
        //static void SelectionMaxMinSort(int[] arr)
        //{
        //    int count = arr.Length;
        //    for (int i = 0; i < count; i++)
        //    {
        //        int maxIndex = i;
        //        for (int j = i + 1; j < count; j++)
        //        {
        //            if (arr[j] > arr[maxIndex])
        //            {
        //                maxIndex = j;
        //            }
        //        }
        //        int temp = arr[maxIndex];
        //        arr[maxIndex] = arr[i];
        //        arr[i] = temp;
        //    }

        //}



    }
}