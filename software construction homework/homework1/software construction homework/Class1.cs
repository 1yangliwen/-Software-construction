using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace software_construction_homework
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int a, b;
            string s;
            /*Write a console program that implements a calculator, which accepts two numbers 
                and an operator as input,  and prints out the calculation result.*/
            Console.WriteLine("please input your first number"); 
            s =  Console.ReadLine();
            a = int.Parse(s);
            Console.WriteLine("please input your first number");
            s = Console.ReadLine();
            b = int.Parse(s);
            Console.WriteLine($"the result is {a + b}");
        }
    }
}
