using algo_worshop;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// a class for the main method to call everyother classes into action !!!
/// there is no need to create an object because they all are static, instead we call the name of the class!!
/// </summary>
public class Algorithm
{
    public static void Main(string[] args)
    {
         Questions.algo();
        int i = 0;
            while (i < 1)
            {
                Console.WriteLine($"\nWould you love to try again \nENTER  :  \n (1) For Yes \n (2) To Quit !!");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Questions.algo();
                Console.WriteLine($"\nThank you for your time!!");
            }
                else if (answer == 2)
                {
                    Console.WriteLine($"Thank you for your time!!");
                }
                i++;

            }
        



    }
}

