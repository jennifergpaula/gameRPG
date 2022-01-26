namespace GameRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, string fantasticClass) : base(name, fantasticClass)
        {
            this.name = name;
            this.fantasticClass = fantasticClass;
            this.level = 1;
            this.lifePoints = 50;
            this.magicPoints = 100;
            
        }
    }
} 