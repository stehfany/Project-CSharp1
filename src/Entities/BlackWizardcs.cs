namespace source.src.Entities
{
  
          public class BlackWizard : Hero
    {

        public BlackWizard(string Name, int Level, string HeroType)
        {
    
        this.Name= Name;
        this.Level = Level;
        this.HeroType = HeroType;

        }
        public override string Attack(){
            return this.Name + " Lançou sua Magia Negra ";
        }

        public  string Attack(int Bonus){

            if(Bonus >= 6){

            return this.Name + " Lançou sua Magia negra super efetiva com bonus de   " + Bonus;

        }else if(Bonus >= 8){
                return this.Name + " Lançou sua Magia negra Suprema com bonus de   " + Bonus;
        
        }else if(Bonus >8){
                return this.Name + " Lançou sua Magia negra Exterminadora com bonus de   " + Bonus;
        }
        
        
        else{
            return this.Name + " Lançou sua Magia negra com força fraca com bonus de  " + Bonus;
        }
        }
    }
}