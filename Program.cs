using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            rectangle rec1 = new rectangle(width,height);

            Console.WriteLine("The area of the rectangle is " + rec1.getArea());
            Console.WriteLine("The perimeter of the rectangle is " + rec1.getPerimeter());

            Console.ReadKey();
        }
    }
}
