namespace source.src.Entities
{
    public class Ninja : Hero
    {

        public Ninja(string Name, int Level, string HeroType)
        {
    
        this.Name= Name;
        this.Level = Level;
        this.HeroType = HeroType;

        }
        public override string Attack(){
            return this.Name + " Atacou com sua estrela da morte";
        }

        public  string Attack(int Bonus){

            if(Bonus >= 6){

            return this.Name + " Lançou sua super estrela da morte  com bonus de   " + Bonus;

        }else if(Bonus >= 8){
                return this.Name + " Lançou sua estrela da Suprema com bonus de   " + Bonus;
        
        }else if(Bonus >8){
                return this.Name + " Lançou sua estela da morte Exterminadora com bonus de   " + Bonus;
        }
        
        
        else{
            return this.Name + " Lançou sua estrela da morte com força fraca com bonus de  " + Bonus;
        }
        }
    }
}