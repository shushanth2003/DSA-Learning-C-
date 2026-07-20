using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RotatedArray
    {
        public int[] nums;
        public int k;
        public RotatedArray(int[] nums,int k)
        {
            this.nums = nums;
            this.k = k;
        }
        public void rotateArray()
        {
            int n = nums.Length;
            rotateReverse(nums, 0, n - 1);
            rotateReverse(nums, k, n - 1);
            rotateReverse(nums, 0, k - 1);

        }
        public void rotateReverse(int[] nums, int start, int end)
        {
            while(start<end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
