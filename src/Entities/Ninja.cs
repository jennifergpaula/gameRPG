namespace GameRPG.src.Entities
{
    public class Ninja : Wizard
    {
          public Ninja(string name, string fantasticClass) : base(name, fantasticClass)
        {
            this.name = name;
            this.fantasticClass = fantasticClass;
            this.level = 1;
            this.lifePoints = 80;
            this.magicPoints = 10;
            
        }
          public override string Attack()
        {
            Random dice = new Random();
            int attackStrength = this.level + dice.Next(1,15);
            this.lastAttackValue = attackStrength;

            return this.name + " attacks with a katana and deals " + attackStrength + " of damage";
        }
    }
}