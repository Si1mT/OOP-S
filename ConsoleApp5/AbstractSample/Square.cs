using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    class Square : Shapes
    {
        int side = 2;
        public override int Area()
        {
            return side * side;
        }
    }
}
