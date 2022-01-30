namespace src.Entites
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        { 
            Random damage = new Random();
            int attack = damage.Next(1,20);
            if (attack > 14)
            {
                return this.Name + ($" Lançou magia super efetiva com bonus de {attack} e tirou {attack*2} de dano.");
            }
            else
            {
                return this.Name + ($" Lançou magia e tirou {attack} de dano.");
            }
        }
    }
}