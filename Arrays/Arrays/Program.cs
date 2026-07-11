using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            SearchElement searchElement = new SearchElement(arr,4,3);
            //Console.WriteLine("Searching Array : " + searchElement.getSearchElement());

            int[] sortArr = { 7, 32, 21, 3, 5 };
            SortedArray sortedArray = new SortedArray(sortArr);

            //make it as for loop
            //Console.WriteLine("Sorted Arrays : ");
            //for (int i=0;i<sortedArray.nums.Length;i++)
            //{
            //    Console.WriteLine(sortedArray.nums[i]);
            //}
            FindPeakElement findPeakElement = new FindPeakElement(arr);
            Console.WriteLine("Find Peak Element : "+findPeakElement.getPeakElement());
        }
    }
}
