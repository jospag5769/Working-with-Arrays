using System;

namespace ConsoleApp1
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            //input from user
            //counters to keep track of how many numbers are above or below the input
            //example array to test against
            int input; 
            int above = 0, below = 0; 
            int[] arrayToTestAgainst = new int[5] {1, 5, 2, 1, 10 }; 

            //getting input and converting the string to an integer
            Console.Write("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            //This for loop is in charge of counting how many numbers are greater than the input
            for(int i = 0; i<arrayToTestAgainst.Length; i++)
            {
                if (input > arrayToTestAgainst[i])
                    below++;
                else if (input < arrayToTestAgainst[i])
                    above++;
            }
            Console.WriteLine("In the array there are {0} numbers above and {1} numbers below the input", above, below);
            Console.WriteLine();
        }
    }
}