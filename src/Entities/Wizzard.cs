namespace Projeto.src.Entities
{
    public class Wizzard : Hero
    {
        public Wizzard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
    }
}