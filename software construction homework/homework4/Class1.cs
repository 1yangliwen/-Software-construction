using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    public class Node<T> 
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }
        public Node(T t) { 
            Next = null;
            Value = t;
        }
    }
    public class Genericlist<T>   //这个尖括号里的T究竟代表了什么呢，所定义的新的数据类型里的某一数据类型会是T？
    {
        private Node<T> head;
        private Node<T> tail;
        public Genericlist()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get { return head; }
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action) {
            Node<T> current = head;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Genericlist<int> list = new Genericlist<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);    
            list.Add(4);
            list.Add(5);
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            list.ForEach(x =>    //对于lamda表达式相当于是等式左边是传入的值，等式右边是根据传入的值做的对应操作
            {
                if (x > max) max = x;
                if (x < min) min = x;
                sum += x;
            });
            Console.WriteLine("min:{0}", min);
            Console.WriteLine("max:{0}", max);
            Console.WriteLine("sun:{0}", sum);
        }
    }
}
