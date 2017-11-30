using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public virtual void Draw() 

        {
            Console.WriteLine("yee");
        }
    }
}
