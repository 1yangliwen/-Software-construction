using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class IntArray
    {   
        public void arrayprocess(int[] arr, int max, int min, int ave, int sum)
        {
            foreach (int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;
                sum += i;
            }
            ave = sum / arr.Length;
        }
    }
}
