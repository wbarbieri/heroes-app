namespace proj_C.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string typeHero) : base(Name, Level, typeHero)
        {
        }

                public override string Attack()
        {
            return this.Name + " " + "Atacou com sua espada";
        }
         public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " " + "Golpe crítico com bonus de " + Bonus;
            }else{
                return this.Name + " " + "Golpe crítico com força fraca de " + Bonus; 
            }
            
        }
    }
}