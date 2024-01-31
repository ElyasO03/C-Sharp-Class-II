using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Class
{
    public abstract class Shapes
    {

        //Constructor


        public Shapes()
        {
            UoM = "inches";
        }

        public string UoM { get; set; }
        
        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        //ends shape

        public class Rectangle : Shapes
        {
            public Rectangle(double l, double w) : base()
            {
                Length = l;
                Width = w;
            }
            //default constructor...this is passing the Rectangle (l,w)

            public Rectangle():this(1,1)
            {

            }

            public double Length { get; set; }

            public double Width { get; set; }

            public override double Area
            {
                get { return Length * Width; }
            }

            public override double Perimeter
            {
                get { return 2 * (Length + Width); }
            }
        }
        public class Square : Shapes
        {
            public Square(double l): base()
            {
                Length = l;
            }
            public Square() : this(1) { }

            public override double Area { get { return Length * Length; } }

            public override double Perimeter { get { return Length * 4;} }
            //area is length times length
            //perimeter is lengths times 4

            public double Length { get; set; }
        }
    }

    public class Circle : Shapes
    {
        public Circle(double r): base()
        {
            Radius = r;
        }

        public Circle(): this (1)
        {

        }

        public double Radius { get; set; }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }
    }
}
