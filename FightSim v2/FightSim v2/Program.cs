using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSim_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skapar två fighters
            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();

            //Ger användaren chans att namnge båda fightersen
            Console.WriteLine("What's the name for:");
            Console.WriteLine("Fighter 1?");
            f1.name = Console.ReadLine();

            Console.WriteLine("Fighter 2?");
            f2.name = Console.ReadLine();
            Console.Clear();

            //En loop som körs så länge båda Fightersen är vid liv
            while (f1.IsAlive() == true && f2.IsAlive() == true)
            {
                //Fightersens hp visas för spelaren
                Console.WriteLine(f1.name + "'s HP: " + f1.GetHp());
                Console.WriteLine(f2.name + "'s HP: " + f2.GetHp());
                Thread.Sleep(100);

                //Fighter 2 tar damagen som Fighter 1 gör i sin attack metod
                f2.Hurt(f1.Attack());
                Console.WriteLine(f1.name + " deals " + f2.Attack() + " to " + f2.name + "!");
                Thread.Sleep(100);

                //Fighter 1 tar damagen som Fighter 2 gör i sin attack metod
                f1.Hurt(f2.Attack());
                Console.WriteLine(f2.name + " deals " + f1.Attack() + " to " + f1.name + "!");
                Console.ReadLine();

                Console.Clear();
            }

            //En if som körs om Fighter 1 är död
            if (f1.IsAlive() == false)
            {
                Console.WriteLine(f2.name + " wins!");

            }
            //If som körs om Fighter 2 är död
            else if (f2.IsAlive() == false)
            {
                Console.WriteLine(f1.name + " wins!");

            }
            //En if som körs om något annat okänt händer
            else
            {
                Console.WriteLine("Random none existing bug encountered :)");

            }

            Console.ReadLine();



        }
    }
}
