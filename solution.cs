// Solution in C#
using System;

namespace ConsoleApp
{
    public class Solution
    {
        private static int[] myArray = { 4, 6, 7, 3, 8 };
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter {0} Integers Array With A Space: ", myArray.Length);
                int[] userArray = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                Console.WriteLine(Solution.HasSameArray(userArray, userArray.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input!");
                //Console.WriteLine(e.Message);
            }
        }
        private static bool HasSameArray(int[] userArray, int userArrayLength)
        {
            if (myArray.Length != userArrayLength)
            {
                return false;
            }
            bool HasSameArray = true;
            for (int i = 0; i < userArrayLength - 1; i++)
            {
                if (myArray[i] != userArray[i])
                {
                    HasSameArray = false;
                }
            }
            return HasSameArray;
        }


    }

}
