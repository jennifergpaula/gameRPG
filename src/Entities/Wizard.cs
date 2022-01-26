namespace GameRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, string fantasticClass) : base(name, fantasticClass)
        {
            this.name = name;
            this.fantasticClass = fantasticClass;
            this.level = 1;
            this.lifePoints = 60;
            this.magicPoints = 120;
        }
         public override string Attack()
        {
            Random dice = new Random();
            int attackStrength = this.level + dice.Next(1,10);
            this.lastAttackValue = attackStrength;

            return this.name + " attacks with magic and deals " + attackStrength + "damage";
        }
        public string Attack(int bonus) {
           Random dice = new Random();
           int attackStrength = this.level + dice.Next(1,30) + bonus;
           this.lastAttackValue = attackStrength;

           return this.name + " attacks with a bonus magic and deals " + attackStrength + "damage";
        }
    }
}