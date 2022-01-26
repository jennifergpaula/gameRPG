using GameRPG.src.Entities;

namespace GameRPG
{
class Program
    {
         static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", "Knight");
            Wizard wedge = new Wizard("Wedge", "Black Wizard");
            Enemy belzebu = new Enemy("Belzebu", "Zombie");
            Wizard jennica = new Wizard("Jennica", "White Wizard");
            Enemy golum = new Enemy("Golum", "Monster");
            Ninja lilith = new Ninja("Lilith", "Ninja");

           System.Console.WriteLine(arus.Attack());
           System.Console.WriteLine(lilith.Attack());

            if(arus.lastAttackValue == belzebu.lastAttackValue){
            System.Console.WriteLine("A tie! Both received " + arus.lastAttackValue + " of damage");
            } else if(arus.lastAttackValue > belzebu.lastAttackValue){
                belzebu.damageTaken(arus.lastAttackValue - belzebu.lastAttackValue);
                System.Console.WriteLine(arus.name + " won this round");
            } else{
                arus.damageTaken(belzebu.lastAttackValue - arus.lastAttackValue);
                System.Console.WriteLine(belzebu.name + " won this round");
            }


            Console.WriteLine(arus.lastAttackValue);
            Console.WriteLine(lilith.lastAttackValue);
           
        }
        
    }
}