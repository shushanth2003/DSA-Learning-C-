using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SearchElement
    {
        public int n;
        public int target;
        public int[] num;
        public SearchElement(int[] num,int n,int target)
        {
            this.num = num;
            this.n = n;
            this.target = target;
        }

        public int getSearchElement()
        {
            for(int i=0;i<n;i++)
            {
                if (num[i]==target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
