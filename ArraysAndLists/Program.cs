using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            int[] MyArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  // Create an int Array and populate numbers 1-10

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            

            for (int i = 0; i <= MyArray.Length;  i++)
            {
                if (i % 2 == 0)
                {               
                    evens.Add(i);
                }
                else 
                {                  
                    odds.Add(i);                   
                }

            }
            Console.WriteLine($"list of even numbers: ");
            foreach (var even in evens) 
            { 
                Console.WriteLine(even);
            }
            Console.WriteLine($"list of odd numbers; ");
            foreach(var odd in odds)
            { 
                Console.WriteLine(odd);
            }
            
            
            
            
            /* Create two Lists of type int.
                                        * Name one List "evens"
                                        * Name the other List "odds"
                                         */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
