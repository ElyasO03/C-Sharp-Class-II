using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Week2_Class.Shapes;

namespace Week2_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Week2_Class.Shapes.Rectangle(20, 25);

            ShowShapes(r1);

            var s1 = new Square(5);
            ShowShapes(s1);

            var s2 = new Square();
            ShowShapes(s2);

            Circle c1 = new Circle(10);
            ShowShapes(c1);

            ReadKey();
        }//ends main

        static void ShowShapes(Shapes s)
        {
            WriteLine($"{s.GetType().Name}\t\tArea = {s.Area}\t\tPerimeter = {s.Perimeter}\t\tUOM= {s.UoM}");
            WriteLine();
        }

    }
}
