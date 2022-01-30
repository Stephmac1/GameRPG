namespace src.Entites
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }
        public Hero()
        {

        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

    public virtual string Attack()
    {
        Random damage = new Random();
        int attack = damage.Next(1,20);
        return this.Name + ($" Atacou com a sua espada e tirou {attack} de dano");
    }
    }
}