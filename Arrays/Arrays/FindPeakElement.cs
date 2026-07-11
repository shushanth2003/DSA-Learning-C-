using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class FindPeakElement
    {
        public int[] arr;
        public FindPeakElement(int[] arr)
        {
            this.arr = arr;
        }

        public int getPeakElement()
        {
            int maximum = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if (maximum < arr[i])
                {
                    maximum = arr[i];
                }
            }
            for(int j=0;j<arr.Length;j++)
            {
                if (arr[j]==maximum)
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
