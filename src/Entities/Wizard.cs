namespace proj_C.src.Entities

{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string typeHero) : base(Name, Level, typeHero)
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
                return this.Name + " " + "Lançou magia com força fraca com bunus de " + Bonus; 
            }
            
        }
    }
}