namespace proj_C.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string typeHero) : base(Name, Level, typeHero)
        {
        }

             public override string Attack()
        {
            return this.Name + " " + "Atacou com sua espada";
        }
         public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " " + "Lançou uma boma de fumaça com bonus de " + Bonus;
            }else{
                return this.Name + " " + "Lançou uma boma de fumaça com força fraca de " + Bonus; 
            }
            
        }
    }
}