using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Line
    {

        public void CalculateLength()
        {
            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double x = (x2 - x1) * (x2 - x1);
            double y = (y2 - y1) * (y2 - y1);
            double z = x + y;
            double length = Math.Sqrt(z);
            Console.WriteLine("Length of the line is " + length);
        }
    }
}
