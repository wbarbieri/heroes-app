namespace proj_C.src.Entities
{
    public class BWizard : Hero
    {
         public BWizard(string Name, int Level, string typeHero) : base(Name, Level, typeHero)
        {
        }
         public override string Attack()
        {
            return this.Name + " " + "Lançou magia";
        }
         public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " " + "Lançou super magia com bonus de " + Bonus;
            }else{
                return this.Name + " " + "Lançou magia com força fraca de " + Bonus; 
            }
            
        }
    }
}