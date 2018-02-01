using System;

namespace ConsoleAppX
{
    class Wolf : Monster
    {
        public Wolf()
        {
            Name = "Wolf";
            HP = 50;
            AP = 15;
            Defence = 25;
        }
        public override int Attack(int hp)
        {
            Console.WriteLine(Name + " bit you!");
            Console.WriteLine(Name + " did " + AP + " damage");
            var userHitpoints = hp - AP;
            Console.WriteLine("Player has " + userHitpoints + " HP");
            return userHitpoints;
            //return hp-15;
        }
        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " did super bite!");
            Console.WriteLine(Name + " did " + AP + " damage");
            var userHitpoints = hp - AP;
            Console.WriteLine("Player has " + userHitpoints + " HP");
            return userHitpoints;
            //return hp-15;
        }
    }
}
