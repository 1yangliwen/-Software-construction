using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    abstract class shape
    {
        protected double edge1, edge2, edge3;
        protected double area;
        public abstract bool legal();
    }
    public interface Compute {
        double areaCompute();
    }
    class square : rectangle, Compute
    {
        public square(double l1, double l2, double l3, double l4) : base(l1, l2, l3, l4)
        {
            edge1 = l1; edge2 = l2; edge3 = l3; edge4 = l4;
        }
        public override bool legal()
        {   
            if ((edge1 == edge2) && (edge3 == edge4) && (edge2 == edge3)) return true;
            return false;
        }
        double Compute.areaCompute()
        {   
            if (!legal()) return -1;
            area = edge1*edge1; return area;
        }
    }
    class rectangle : shape, Compute
    {
        protected double edge4;
        public rectangle(double l1, double l2, double l3, double l4)
        {
            edge1 = l1; edge2 = l2; edge3 = l3; edge4 = l4;
        }
        public override bool legal()
        {    
            if ((edge1 == edge2 && edge3 == edge4) || (edge1 == edge3 && edge4 == edge2) || (edge1 == edge4 && edge3 == edge2)) return true;
            return false;
        }
        double Compute.areaCompute()
        {
            if (!legal())
            {
                return -1;
            }

            area = edge1 * edge2; return area;
        }
    }
    class triangle : shape , Compute
    {
        public triangle(double l1, double l2, double l3)
        {
            edge1 = l1; edge2 = l2; edge3 = l3;
        }
        double Compute.areaCompute()
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
        public static shape CreateShape(string type, double l1, double l2, double l3, double l4 = 0)
        {
            switch (type.ToLower())
            {
                case "square":
                    return new square(l1, l2, l3, l4);
                case "rectangle":
                    return new rectangle(l1, l2, l3, l4);
                case "triangle":
                    return new triangle(l1, l2, l3);
                default:
                    throw new ArgumentException($"未知类型：{type}");
            }
        }
    }

}
