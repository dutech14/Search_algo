using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace algo_worshop
{

    public static class SortingAlgorithms
    {
        public static void bubblesort(int[] file_to_be_searched) 
        {
            int counter = 0;
            int a = file_to_be_searched.Length;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = 0; j < a - 1 - i; j++)
                {
                    counter++;
                    if (file_to_be_searched[j + 1] < file_to_be_searched[j])//checks if the first number is greater than the number to it's right
                    {
                        int temp = file_to_be_searched[j];
                        file_to_be_searched[j] = file_to_be_searched[j + 1];//swaps it if it meets the condition 
                        file_to_be_searched[j + 1] = temp;
                        //and continues that until the file is all sorted
                    }
                }
            }
            Console.WriteLine($"\n It took {counter}steps to sort the file in ascending order");

        }
        public static void bubblesort_reversed(int[] file_to_be_searched)// does the bubble sort again to get the file sorted in descending order
        {
            int counter = 0;
            int a = file_to_be_searched.Length;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = 0; j < a - 1 - i; j++)
                { counter++;
                    if (file_to_be_searched[j ] < file_to_be_searched[j+1])
                    {
                        int temp = file_to_be_searched[j + 1];
                        file_to_be_searched[j+1] = file_to_be_searched[j];
                        file_to_be_searched[j] = temp;
                    }
                }
            }
            Console.WriteLine($"\n It took {counter } steps to get to sort the file in descending order");


        }
        public static void Quick_Sort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];// picsk the pivot from the center of the list 
            do
            {
                // checks both sides of the pivot to place those higher on the right side and those lower on the left side
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }

                // picks the left hand side and sorts them in ascending order and does the same to the right hand side respectively
            } while (i <= j);
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);

        }

        public static int[] MergeSort(int[] unsorted)
        {
            if (unsorted.Length <= 1)
                return unsorted;

            int[] left = unsorted[0..(unsorted.Length/2)];
            int[] right = unsorted[(unsorted.Length/2)..unsorted.Length];
            int middle = unsorted.Length / 2;

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int [] right)
        {
            int[] result = new int[left.Length+right.Length];

            int leftCounter = 0;
            int rightCounter = 0;
            int counter = 0;
            while (leftCounter < left.Length && rightCounter < right.Length)
            {
                if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                {
                    result[counter] = left[leftCounter];
                    counter++;
                    leftCounter++;
                    //left.Remove(left.First());      //Rest of the list minus the first element
                }
                else
                {
                    result[counter] = right[rightCounter];
                    counter++;
                    rightCounter++;
                }
            }

            while (leftCounter != left.Length)
            {
                result[counter] = left[leftCounter];
                counter++;
                leftCounter++;
            }
            while (leftCounter != right.Length)
            {
                result[counter] = right[rightCounter];
                counter++;
                rightCounter++;
            }

            {

            }
            return result;
        }
        public static void Output_every_nth(int[] array, int n)// returns every one of the 10th or 50th term depending on the selected file by the user
        {
            for (int i = n; i < array.Length; i += n)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Output_array(int[] array)
        {
            // selects the term to be returned depending on the selected file to be searched 
            if (array.Length >= 2048)
            {
                Console.WriteLine($"\n every 50th value is : ");
                Output_every_nth(array, 50);
            }
            else
            {
                Console.WriteLine($"\n every 10th value is : ");
                Output_every_nth(array, 10);
            }
        }
        // this iterates through the file and searches for the user's input and returns 
    }
}


    


     


    

