using System;

namespace ConsoleAppX
{
    abstract class Monster
    {
        protected string Name;
        protected int HP;
        protected int AP;
        protected int Defence;
        protected bool Ranged;

        public virtual int Attack(int hp)
        {
            Console.WriteLine(Name + " attacked you!");
            Console.WriteLine(Name + " did " + AP + " damage");
            var userHitpoints = hp - AP;
            Console.WriteLine("Player has " + userHitpoints + " HP");
            return hp-15;
        }

        public abstract int SpecialAttack(int hp);
    }
}
