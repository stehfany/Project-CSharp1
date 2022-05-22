namespace source.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
    
        this.Name= Name;
        this.Level = Level;
        this.HeroType = HeroType;

        }
        public override string Attack(){
            return this.Name + " Lançou sua Magia ";
        }

        public  string Attack(int Bonus){

            if(Bonus >= 6){

            return this.Name + " Lançou sua Magia super efetiva com bonus de   " + Bonus;

        }else if(Bonus >= 8){
                return this.Name + " Lançou sua Magia Suprema com bonus de   " + Bonus;
        
        }else if(Bonus >8){
                return this.Name + " Lançou sua Magia Exterminadora com bonus de   " + Bonus;
        }
        
        
        else{
            return this.Name + " Lançou sua Magia com força fraca com bonus de  " + Bonus;
        }
        }
    }

}