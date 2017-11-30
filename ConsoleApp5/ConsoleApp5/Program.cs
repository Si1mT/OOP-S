using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new Shape();
            shape1.x = 10;
            shape1.y = 20;
            shape1.Width = 100;
            shape1.Length = 500;
            //shape1.Draw();

            var circle1 = new Circle();

            circle1.x = 100;
            circle1.y = 200;
            circle1.Width = 2145;
            circle1.Length = 124;
            //circle1.Draw();

            var rectangle1 = new Rectangle();
            rectangle1.x = 1000;
            rectangle1.y = 200;
            rectangle1.Width = 200;
            rectangle1.Length = 123;
            //rectangle1.Draw();

            var triangle1 = new Triangle();
            triangle1.x = 42;
            triangle1.y = 1535;
            triangle1.Width = 11111;
            triangle1.Length = 2222;
            //triangle1.Draw();

            var shapes = new List<Shape>();
            shapes.Add(circle1);
            shapes.Add(triangle1);
            shapes.Add(rectangle1);
            shapes.Add(shape1);

            foreach (var i in shapes) 
            {
                i.Draw();
            }
            Console.ReadLine();

        }
    }
}
