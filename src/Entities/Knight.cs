namespace source.src.Entities
{
    public class Knight : Hero 
    {
        public Knight(string Name, int Level, string HeroType)
        {
        this.Name= Name;
        this.Level = Level;
        this.HeroType = HeroType;

        }
        
          public override string Attack(){
            return this.Name + " Atacou com sua espada";
        }
  public  string Attack(int Bonus){

            if(Bonus >= 6){

            return this.Name + " Lançou sua com sua Faca com bonus de   " + Bonus;

        }else if(Bonus >= 8){
                return this.Name + " Lançou sua sua Faca Suprema com bonus de   " + Bonus;
        
        }else if(Bonus >8){
                return this.Name + " Lançou sua Faca Exterminadora com bonus de   " + Bonus;
        }
        
        
        else{
            return this.Name + " Lançou sua Faca com força fraca com bonus de  " + Bonus;
        }
        }
    }
}
    
