namespace GameRPG.src.Entities
{
    public class Hero
    {
        public Hero(string name, string fantasticClass)
        {
            this.name = name;
            this.fantasticClass = fantasticClass;
            this.level = 1;
            this.lifePoints = 50;
            this.magicPoints = 100;
            
        }
        public string name { get; set; }
        public int level { get; set; }
        public int lifePoints { get; set; }
        public int magicPoints { get; set; }
        public string fantasticClass { get; set; }
        public int lastAttackValue { get; set;}

        public override string ToString(){
            return "Hi, my name is " + this.name + "\n"
                + "Level: " + this.level + "\n"
                + "Class: " + this.fantasticClass + "\n"
                + "Life Points: " + this.lifePoints + "\n"
                + "Magic Points: " + this.magicPoints + "\n";
        }

        public virtual string Attack(){
            Random dice = new Random();
            int attackStrength = this.level + dice.Next(1,20);
            this.lastAttackValue = attackStrength;

            return this.name + " attacks with the sword and deals " + attackStrength + " damage";
        }

        public void damageTaken(int damageTaken){
            this.lifePoints -= damageTaken;
        }

    }
}