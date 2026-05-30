using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class shape
    {
        public abstract void ClculateArea();
         
    }
    class circle : shape
    {
        public double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override void ClculateArea()
        {
            Console.WriteLine("Area of circle is : " + (3.14 * radius * radius));
        }
    }

    class rectangle : shape
    {
        public double length;
        public double width;
        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override void ClculateArea()
        {
            Console.WriteLine("Area of rectangle is : " + (length * width));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
