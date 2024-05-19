using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
///<summary>
///This class is created for most of the questions that the user would be asked!!
///</summary>
///
namespace algo_worshop
{
    internal static class Questions
    {
        public static void Search_questions(int[] roadData)
        {
            Console.WriteLine($"input a number to be searched :\t");
            int number = int.Parse(Console.ReadLine());
            int location = Search_algorithms.linear_Search_algorithm(roadData, number);
            // if the number is not in the file, it searches back and forth for the closest number to the one provided by the user
            //  location = Search_algorithms.linear_Search_algorithm(roadData, number);
            if (location == -1)
            {
                Console.WriteLine($"({number}) not present in the file");
                int nearest = Search_algorithms.FindNearest(roadData, number);
                Console.WriteLine($"The Nearest value is {nearest}");
                for (int i = 0; i < roadData.Length; i++)
                {
                    if (roadData[i] == nearest)
                    {
                        Console.WriteLine($"({nearest}) present at positions: {i + 1}");
                    }
                }
            }
            else
            {
                // gets all the location(s) if number is present in file 
                for (int i = 0; i < roadData.Length; i++)
                {
                    if (roadData[i] == number)
                    {
                        Console.WriteLine($"{number} present at positio(s) {i + 1}");
                    }
                }
            }
        }

        public static int[] LoadQuestion()
        {
            int user_input = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine($"What road will you like to read please Enter:\n(1) to read file_1_256\n(2) to read file_2_256\n(3) to read file_3_256\n(4) to read file_1_2048\n(5) to read file_2_2048\n(6) to read file_3_2048\n(7) to read the merged file (1) and (3) 256\n(8) to read (1) and (3) merged");


                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1 || user_input == 2 || user_input == 3 || user_input == 4 || user_input == 5 || user_input == 6 || user_input == 7 || user_input == 8)
                    {
                        valid = true;
                        return RoadReader.filereader(user_input);// passes the user input into the filereader and performs the file reading!!
                    }
                    Console.WriteLine($"There is no file ({user_input}) present !!, please try again:!!");
                }
                // Console.WriteLine($"Please input an integer");

            }
            return new int[0];
        }
        public static int sorting_question()
        // this function is to ask the user if they'd like to sort the list or not
        {
            bool valid = false;
            int algorithm = 0;
            while (!valid)
            {
                Console.WriteLine($"Would you love to search a sorted file or an Non-sorted file :\n ENTER :\n(1) for Sorted \n(2) for Non - sorted! ");
                if (int.TryParse(Console.ReadLine(), out algorithm))
                {
                    if (algorithm == 1 || algorithm == 2)
                    {
                        valid = true;
                        return algorithm;

                    }
                    Console.WriteLine($"invalid input");
                }
                Console.WriteLine($"invalidility");
            }
            return -1;
        }
        public static void algo()
        {
            //this function is also to ask the user if they'd like to sort the file in ascending and descending order ...else it does the last condition!!
            int[] roadData = Questions.LoadQuestion();

            int user_answer = Questions.sorting_question();
            if (user_answer == 1)
            {
                Console.WriteLine($"Ascending order or Descending order ? \n ENTER :\n (1) for bubble sort Ascending order\n(2) for bubble sort Descending order \n (3) for quick sort");
                int order = int.Parse(Console.ReadLine());
                if (order == 1)
                {
                    SortingAlgorithms.bubblesort(roadData); // calls the bubblesort method and appends the user 
                    Console.WriteLine("Sorted ascending");
                    SortingAlgorithms.Output_array(roadData);

                    Questions.Search_questions(roadData);
                }
                else if (order == 2)
                {
                    // SortingAlgorithms.bubblesortdescendingorder(roadData);
                    SortingAlgorithms.bubblesort_reversed(roadData);
                    Console.WriteLine("Sorted descending");
                    SortingAlgorithms.Output_array(roadData);

                    Questions.Search_questions(roadData);
                }
                else if (order == 3)
                {
                    //sorts with quick sort
                    SortingAlgorithms.Quick_Sort(roadData, 0, roadData.Length - 1);
                    Console.WriteLine("Sorted with quick sorting");
                    SortingAlgorithms.Output_array(roadData);

                    Questions.Search_questions(roadData);

                }
                else if (order == 4)
                {
                    SortingAlgorithms.MergeSort(roadData);
                    Console.WriteLine("Sorted with quick sorting");
                    SortingAlgorithms.Output_array(roadData);

                    Questions.Search_questions(roadData);
                }

            }
            else if (user_answer == 2)
            {
                Console.WriteLine("Unsorted");
                SortingAlgorithms.Output_array(roadData);
                Questions.Search_questions(roadData);
            }
        }

    }
}
