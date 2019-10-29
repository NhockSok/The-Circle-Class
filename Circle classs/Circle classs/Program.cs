using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_classs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The Circle has radius of {0} and area of {1}" , c1.getRadius() ,c1.getArea());

            Circle c2 = new Circle(2.0);
            Console.WriteLine("The Circle has radius of " + c2.getRadius() + " and area of " + c2.getArea());

            Circle c3 = new Circle(3,"Yellow");
            Console.WriteLine("The Circle has radius of {0} and color of {1}", c3.getRadius(), c3.getColor());

            Console.WriteLine(c3.ToString());

        }
    }
}
