using System;

namespace ConsoleAppX
{
    class Ape : Monster
    {
        public Ape()
        {
            Name = "Ape";
            HP = 50;
            AP = 15;
            Defence = 25;
            Ranged = true;
        }
        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " did super bite!");
            Console.WriteLine(Name + " did " + AP + 10 + " damage");
            var userHitpoints = hp - AP-10;
            Console.WriteLine("Player has " + userHitpoints + " HP");
            return userHitpoints;
            //return hp-15;
        }
    }
}
