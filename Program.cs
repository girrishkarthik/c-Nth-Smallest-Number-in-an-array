using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthSmallNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] find = { 47, 22, 17, 898, 99, 500, 33 };
            Console.WriteLine(NthSmall(find, 6)); // find the 6th smallest value in the "find" array
            Console.ReadLine();
        }

        /// <summary>
        /// Used to find the nth smallest value from an array of numbers
        /// </summary>
        /// <param name="arr">array from which you want to find the nth smallest value</param>
        /// <param name="n">Index/Ranking of the smallest value</param>
        /// <returns>nth smallest value</returns>
        static private int NthSmall(int[] arr, int n)
        {
            int nth=0;
            List<int> resultArr = new List<int>();
            int min = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {
                int[]arr2 = (from a in arr where !resultArr.Contains(a) select a).ToArray();
                min = arr2[0];

                for (int i = 0; i < arr2.Length; i++)
                {
                    if(arr2[i]<=min)
                    {
                        min = arr2[i];
                    }

                }

                

                if (resultArr.Count < n && !resultArr.Contains(min))
                {
                    resultArr.Add(min);
                    nth = resultArr[resultArr.Count - 1];
                }
               
                
               


            }
            return nth;
        }
    }
}
