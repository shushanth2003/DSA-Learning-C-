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
        public RotatedArray(int[] arr,int k)
        {
            this.nums = arr;
            this.k = k;
        }

        public void setRotateArray()
        {
            int n = nums.Length;
            reverseRotate(nums, 0, n-1);
            reverseRotate(nums, k, n - 1);
            reverseRotate(nums, 0, k);
        }

        public void reverseRotate(int[] nums, int start,int end)
        {
            while(start<=end)
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
