using System;
using System.Threading;

namespace FunctionOpdracht5
{
    internal class Program
    { 
        string heroName;
        int heroStrength;
        int health;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }


        private void Run()
        {

			Console.WriteLine("choose your hero's name");
            heroName = GetHeroName(); //heroName zit op Program (this)

            Console.WriteLine($"your hero is called {heroName}");
            Thread.Sleep(1000);

            SetHeroStrength(9999);//super sterk natuurlijk

            SetHealth(1000);

            //1) roep hier de SetHealth aan met een 1000;

            while(IsHeroDead())//4) maak deze function, deze geeft een true  terug als health <= 0, anders geeft deze false terug
            {
                //fight!

               	int dam = RollDamage();//5) maak deze function, je mag een random gebruiken of een vast getal
              
            	Console.WriteLine($"your hero takes {dam} damage");
                Thread.Sleep(1000);
                DoDamageToHero(dam);//6) maak deze function, deze haalt dam af van de health (op program)
                if (health <= 0 || health == 0 )
                {
                    Console.WriteLine("your hero is dead");
                    break;
                }
            	Console.WriteLine($"your hero has {health} health");
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);

            Console.WriteLine("oefening compleet!");
            Thread.Sleep(1000);
        }

        private string GetHeroName()
        {
            string Name = Console.ReadLine();
            return Name;
        }

        //2) maak hier een function GetHeroName die met Console.ReadLine() een helden naam vraagt

        private void SetHeroStrength(int heroStrength)
        {
            heroStrength = 9999;
        }
        //3) maak hier een function SetHeroStrength met 1 argument  van type 'int'
        //in de body van de function zet de waarde van heroStrength (van program) het 

        private bool IsHeroDead()
        {
            if (health <= 0 || health == 0) return false;
            else return true;
        }

        private int RollDamage()
        {
            Random rnd = new Random();
            int number = rnd.Next(500, 1000);
            return number;
        }

        private int DoDamageToHero(int dam)
        {
            health = health - dam;
            return health;
        }

        //
        private void SetHealth(int health)
        {
            this.health = health;
        }
    }
}