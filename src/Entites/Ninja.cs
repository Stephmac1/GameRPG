namespace src.Entites
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            Random damage = new Random();
            int attack = damage.Next(1,20);
            return this.Name + ($" Atacou com sua adaga e tirou {attack} de dano.");
        }
    }
}