using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SortedArray
    {
        public int[] nums;
        public SortedArray(int[] arr)
        {
            this.nums = arr;
        }

        public int[] getSortedArray()
        {
            Array.Sort(this.nums);
            return this.nums;
        }

        
    }
}
