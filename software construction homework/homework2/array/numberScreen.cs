using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class NumberScreen
    {   
        static void Main(string[] args)
        {
            var screen = new NumberScreen();
            bool[] arr = new bool[101];
            for (int i = 0; i < arr.Length;i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            arr[1] = false;
            for (int i = 2; i < 11; i++) { 
                if (arr[i])
                {
                    for (int j = i*i;  j < 101; ) {
                        arr[j] = false;
                        j += i;
                    }                      
                }
            }
            for (int i = 0;i < 101; i++)
            {
                if (arr[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
