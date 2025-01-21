using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_purposes_only
{
    internal class Program
    {

        public class Circle
        {
            public  const double Pi = 3.14159; // Constant
            public static double radius = 5; // Field

            public void area() { Console.WriteLine("Woof!"); }
        }

        static void Main(string[] args)
        {
            //double area = Circle.Pi * radius
            Circle c1 = new Circle();

            c1.area();


        }
    }
}
