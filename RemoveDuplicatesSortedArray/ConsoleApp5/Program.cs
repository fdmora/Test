using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Remove Duplicates from Sorted Array
namespace RemoveDuplicatesSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
           int[] ns1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            b =RemoveDuplicates(ns1);
            Console.WriteLine(b);
            Console.ReadLine();


            int RemoveDuplicates(int[] nums)
            {

                if (nums.Length == 0) return 0;

                int i = 0;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j] != nums[i])
                    {
                        i++;
                        nums[i] = nums[j];
                    }
                }
                return i + 1;
            }    



        }



    }

}
