namespace GameRPG.src.Entities
{
    internal class Enemy : Hero
    {
        public Enemy(string name, string fantasticClass) : base(name, fantasticClass)
        {
            this.name = name;
            this.fantasticClass = fantasticClass;
            this.level = 1;
            this.lifePoints = 30;
            this.magicPoints = 70;
        }
        public override string Attack()
        {
            Random dice = new Random();
            int attackStrength = this.level + dice.Next(1,15);
            this.lastAttackValue = attackStrength;

            return this.name + " attacks with the sword and deals " + attackStrength + " of damage";
        }
    }
}