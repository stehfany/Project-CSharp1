namespace source.src.Entities
{
       public class Demon : Boss
    {

        public Demon(string Name, int Level, string HeroType)
        {
    
        this.Name= Name;
        this.Level = Level;
        this.BossType = HeroType;

        }
        public override string Attack(){
            return this.Name + " Contra-atacou com seu uivo diabolico com bonus de 20";
        }

}
}