using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HelloWorld;
namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Circle
            Circle objcircle = new Circle();
            Console.WriteLine(objcircle.getArea());

            //Rectangle
            Rectangle objRectangle = new Rectangle();
            Console.WriteLine(objRectangle.getArea());

            //Triangle

            Triangle objTriangle = new Triangle();
            Console.WriteLine(objTriangle.getArea());

        }


    }


    public class Shape()
    {
        public virtual double getArea()
        {
            double formula = 0;

            return (formula);
        }


    }


    public class Circle : Shape

    {
        private double radius = 5;

        public override double getArea()
        {
            double formula;
            formula = 3.1416 * radius * radius;
            return (formula);
        }
    }


    public class Rectangle : Shape

    {
        private double width = 6;
        private double height = 4;

        public override double getArea()
        {
            double formula;
            formula = width * height;
            return (formula);
        }
    }


    public class Triangle : Shape

    {
        private double _base = 3;
        private double height = 4;

        public override double getArea()
        {
            double formula;
            formula = (_base * height) / 2;
            return (formula);
        }
    }

}