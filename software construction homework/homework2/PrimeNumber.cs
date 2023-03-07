using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
     
            int y = 0;
            System.Console.WriteLine("input a number");
            string str = Console.ReadLine();
            y = int.Parse(str);
            PrimeNumber class1 = new PrimeNumber();
                for (int i = 2; i <= y; i++)
                {
                    int n = i;
                    while ((y % n) == 0)
                    {
                        //printf("%d是素数因子吗？%d\n",n,judge(n));  //1表示是素数，0表示非素数；
                        if (class1.judge(n)) Console.WriteLine("{0}",n);
                        y = y / n;
                    }
                }            
        }

        public bool judge(int n)
        {//判断n是否为素数
            if (n < 2) return false;  //素数必须大于1；
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

    }
}
