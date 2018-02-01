using System;

namespace ConsoleAppX
{
    class Program
    {
        static void Main(string[] args)
        {
            //create player
            var hp = 100;
            //create enemy
            var EnemyWolf = new Wolf();
            hp = EnemyWolf.Attack(hp);

            Console.WriteLine();

            var Ape = new Ape();
            hp = Ape.Attack(hp);

            Console.WriteLine();

            var fireWolf = new FireWolf();
            fireWolf.Attack(hp);

            //var Monster = new Monster();
            //Monster.Name = "Monster";
            //Monster.AP = 50;
            //Monster.HP = 50;
            //Monster.Attack(hp);


            Console.ReadLine();
        }
    }
}
