namespace source.src.Entities;

   public abstract class Boss
{
    public Boss(string Name, int Level, string HeroType)
    {
     this.Name= Name;
     this.Level = Level;
     this.BossType = HeroType;
    }

     public Boss(){

     }
     
    public string Name;
    public int Level;
    public string BossType;



public override string ToString(){
    
    return this.Name + " " + this.Level + " " + this.BossType;

    
        
    }

    public virtual string Attack(){
        return this.Name + " Atacou com a seu uivo Infernal";
    }

    
}