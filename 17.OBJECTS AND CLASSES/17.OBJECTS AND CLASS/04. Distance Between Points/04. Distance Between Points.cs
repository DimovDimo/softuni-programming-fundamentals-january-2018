﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var point2 = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            Point p1 = new Point();
            p1.X = point1[0];
            p1.Y = point1[1];
            Point p2 = new Point();
            p2.X = point2[0];
            p2.Y = point2[1];
            Console.WriteLine($"{Point.CalcDistance(p1, p2):F3}");
        }

        //class Point
        //{
        //    public double X { get; set; }
        //    public double Y { get; set; }
        //    static public double CalcDistance(Point p1, Point p2)
        //    {
        //        var sideA = Math.Pow(p1.X - p2.X, 2);
        //        var sideB = Math.Pow(p1.Y - p2.Y, 2);
        //        return Math.Sqrt(sideA + sideB);
        //    }
        //}
    }
}
