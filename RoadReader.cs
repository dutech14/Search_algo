using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_worshop
{
    internal static class RoadReader
    {
        public static int[] filereader(int fileNumber)
        {
            int[] numbers = new int[0];
            string[] fileNames = new string[] { "Road_1_256.txt", "Road_2_256.txt", "Road_3_256.txt", "Road_1_2048.txt", "Road_2_2048.txt","Road_3_2048.txt" ,"Road_4_256.txt","Road_4_2048.txt"};
            string fileName = fileNames[fileNumber-1];

            string[] lines = File.ReadAllLines($"C:/Users/temid/Downloads/{fileName}");
            numbers = new int[lines.Length];//introduces a new array of integers with the length of the read file
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);// converts every element in the previously read file to integer
            }
            return numbers;
        }
    }
    //public static void copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, long length)
    //{
    //    string[] file_to_copy = File.ReadAllLines("C:/Users/temid/Downloads/Road_1_256.txt");
    //    sourceArray = file_to_copy;
    //    sourceIndex = file_to_copy.Length;
    //    string[] file_to_copy2 = File.ReadAllLines("C:/Users/temid/Downloads/Road_3_256.txt");
    //    destinationArray = file_to_copy2;
    //    destinationIndex = file_to_copy2.Length;
    //    length = destinationIndex + sourceIndex;
    //}
}
