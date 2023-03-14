using homework3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework3
{
    public abstract class Shape
    {
        protected double edge1, edge2, edge3;
        protected double area;
        public abstract bool legal();
    }
    public interface Compute {
        double AreaCompute();
    }
    class Square : Rectangle, Compute
    {
        public Square(double l1) : base(l1, 0)
        {
            edge1 = edge2 = edge3 = edge4 = l1;
        }
        public override bool legal()
        {   
            if (edge1 > 0) return true;
            return false;
        }
        double Compute.AreaCompute()
        {   
            if (!legal()) return -1;   // 抛出异常而不是一个负值
            area = edge1*edge1; return area;
        }
    }
    class Rectangle : Shape, Compute
    {
        protected double edge4;
        public Rectangle(double l1, double l2)
        {
            edge1 = edge2 = l1; edge3 = edge4 = l2;
        }
        public override bool legal()
        {    
            if (edge1 > 0 && edge3 > 0) return true;
            return false;
        }
        double Compute.AreaCompute()
        {
            if (!legal())
            {
                return -1;
            }

            area = edge1 * edge2; return area;
        }
    }
    class Triangle : Shape , Compute
    {
        public Triangle(double l1, double l2, double l3)
        {
            edge1 = l1; edge2 = l2; edge3 = l3;
        }
        double Compute.AreaCompute()
        {   
            if (!legal()) return -1;
            double s = (edge1 + edge2 + edge3) / 2;
            double area = Math.Sqrt(s * (s - edge1) * (s - edge2) * (s - edge3));
            area = edge1 * edge2; return area;
        }
        public override bool legal()
        {
            if ((edge1 - edge2 < edge3) || (edge1 + edge2 > edge3)) return true;
            return false;
        }
    }
    public class ShapeFactory
    {
        public static Compute CreateShape(string type, double l1, double l2, double l3, double l4 = 0)
        {
            switch (type.ToLower())
            {
                case "square":
                    return new Square(l1);
                case "rectangle":
                    return new Rectangle(l1, l2);
                case "triangle":
                    return new Triangle(l1, l2, l3);
                default:
                    throw new ArgumentException($"未知类型：{type}");
            }
        }
        public static Compute CreateRandomShanpe()
        {
            Random random = new Random();
            int seed = (int)DateTime.Now.Ticks & 0x0000FFFF;
            Thread.Sleep(10);
            random = new Random(seed);
            int randomNumber = random.Next(1, 4); // 随机数生成范围是 [1, 3]
            int ran1 = random.Next(1, 11); // 随机数生成范围是 [1, 9]
            int ran2 = random.Next(1, 11);
            switch (randomNumber)
            {
                case 1:
                    Compute s1 = CreateShape("square", ran1, ran1, ran1, ran1);
                    System.Console.WriteLine("generate a square {0}", ran1);
                    return s1;
     
                case 2:
                    Compute s2 = CreateShape("rectangle", ran1, ran2, ran1, ran2);
                    
                    System.Console.WriteLine("generate a rectangle {0}, {1}", ran1, ran2);
                    return s2;
                case 3:
                    int ran3 = random.Next(1, 11);
                    Compute s3 = CreateShape("triangle", ran1, ran2, ran3);
                  
                    System.Console.WriteLine("generate a triangle {0}, {1}, {2}", ran1, ran2, ran3);
                    return s3;
            }
            return null;
        }
    }
 
    public class process {
    static void Main(string[] args)
    {
        double areaSum = 0;

        for (int i = 0; i < 10; i++)
        {
            Compute s = ShapeFactory.CreateRandomShanpe();
            areaSum += s.AreaCompute();
        }

        System.Console.WriteLine("以下为10个形状面积之和");
        System.Console.WriteLine(areaSum);
    
    }
}
}  


