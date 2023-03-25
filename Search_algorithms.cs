using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_worshop
{
    public class Search_algorithms
    {
        //thisssssssssssssssssssssssssssssssssssssssssssss
        public static int binary_search_algorithm(int[] inputArray, int key)
        {

            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;

        }
        public static int linear_Search_algorithm(int[] road, int user_search, int start = 0)
        {
            int counter = 0;
            for (int i = start; i < road.Length; i++)// iterates through the list and checks for the user input
            {
                counter ++;
                if (road[i] == user_search) //if the input is int the file...it returns the location`
                {
                   // Console.WriteLine($"\nit took {counter} steps to get to {user_search}");

                    return i;

                }

            }
            return -1;
        }
        public static int FindNearest(int[] array, int target)
        {// this function returns the nearest value should the value entered by the user not found in the file
            bool found = false;
            int offset = 1;
            while (!found)
            {
                if (Search_algorithms.linear_Search_algorithm(array, target + offset) != -1)// checks if 
                {
                    found = true;
                    return target + offset;
                }
                if (Search_algorithms.linear_Search_algorithm(array, target - offset) != -1)
                {
                    found = true;
                    return target - offset;
                }
                offset++;
            }
            return -1;
        }

    }
}
