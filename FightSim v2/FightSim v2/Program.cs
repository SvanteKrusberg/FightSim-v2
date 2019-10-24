using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSim_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fighter> fighterLista = new List<Fighter>();
            
            Console.WriteLine("What class do you want to play as?");
            Console.WriteLine("A: Knight");
            Console.WriteLine("B: Ranger");
            Console.WriteLine("C: Wizard");

            bool correctInput = false;
            while (correctInput == false)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "a")
                {
                    fighterLista.Add(new Knight());
                    
                    correctInput = true;
                }
                else if (userInput == "b")
                {
                    fighterLista.Add(new Ranger());
                    
                    correctInput = true;
                }
                else if (userInput == "c")
                {
                    fighterLista.Add(new Wizard());
                    
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Write a correct answer :)");
                    correctInput = false;

                }

            }

            //Ger användaren chans att namnge båda fightersen
            Console.WriteLine("What's your name?");
            fighterLista[0].name = Console.ReadLine();

            Console.WriteLine("What's the name of your foe?");
            Fighter f2 = new Fighter();
            f2.name = Console.ReadLine();
            Console.Clear();

            //En loop som körs så länge båda Fightersen är vid liv
            while (fighterLista[0].IsAlive() == true && f2.IsAlive() == true)
            {
                //Fightersens hp visas för spelaren
                Console.WriteLine(fighterLista[0].name + "'s HP: " + fighterLista[0].GetHp());
                Console.WriteLine(f2.name + "'s HP: " + f2.GetHp());
                Thread.Sleep(100);

                //Fighter 2 tar damagen som Fighter 1 gör i sin attack metod
                if(f2.Hit() == true)
                {
                    f2.Hurt(fighterLista[0].Attack());
                    Console.WriteLine(fighterLista[0].name + " deals " 
                        + fighterLista[0].Attack() + " to " + f2.name + "!");

                    Thread.Sleep(100);

                }
                else
                {
                    Console.WriteLine(fighterLista[0].name + "'s attack missed!");
                }
                
                //Fighter 1 tar damagen som Fighter 2 gör i sin attack metod
                if(fighterLista[0].Hit() == true)
                {
                    fighterLista[0].Hurt(f2.Attack());
                    Console.WriteLine(f2.name + " deals " + f2.Attack() + " to " + fighterLista[0].name + "!");
                    
                }
                else
                {
                    Console.WriteLine(f2.name + "'s attack missed!");

                }
                Console.ReadLine();
                Console.Clear();
            }

            //En if som körs om Fighter 1 är död
            if (fighterLista[0].IsAlive() == false)
            {
                Console.WriteLine(f2.name + " wins!");

            }
            //If som körs om Fighter 2 är död
            else if (f2.IsAlive() == false)
            {
                Console.WriteLine(fighterLista[0].name + " wins!");

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
