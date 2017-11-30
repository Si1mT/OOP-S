using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            Console.WriteLine("Ruudu S on "+square.Area());
            Console.ReadLine();
        }
    }
}
