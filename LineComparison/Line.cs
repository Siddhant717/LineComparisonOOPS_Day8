﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Line
    {

        public void CheckEqualityOfTwoLines()
        {
            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x3 :");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y3 :");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x4:");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y4:");
            double y4 = Convert.ToDouble(Console.ReadLine());


            double x = (x2 - x1) * (x2 - x1);
            double y = (y2 - y1) * (y2 - y1);
            double z = x + y;
            double length1 = Math.Sqrt(z);
            Console.WriteLine("Length of the line1 is " + length1);

            double a = (x4 - x3) * (x4 - x3);
            double b = (y4 - y3) * (y4 - y3);
            double c = a + b;
            double length2 = Math.Sqrt(c);
            Console.WriteLine("Length of the line2 is " + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Both the line1 and line2 are equal");
            }
            else
            {
                Console.WriteLine("Both the line1 and line2 are not equal");
            }
        }
    }
}
