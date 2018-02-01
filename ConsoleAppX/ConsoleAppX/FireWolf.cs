using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppX
{
    class FireWolf:Wolf
    {
        public FireWolf()
        {
            int HP = 200;
            int AP = 50;
        }

        public override int Attack(int hp)
        {
            base.Attack(hp);

            Console.WriteLine("Fayah attacked");
            var userHitpoints = base.Attack(hp);
            return userHitpoints;
        }
    }
}
