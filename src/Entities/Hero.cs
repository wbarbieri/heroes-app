namespace proj_C.src.Entities
{
    public class Hero
    {

        public Hero( string Name, int Level, string typeHero)
        {
          this.Name = Name;
          this.Level = Level;
          this.typeHero =  typeHero;
        }

        public string Name;
        public int Level;
        public string typeHero;

        public override string ToString()
        {
            return (this.Name + " " + this.Level + " " + this.typeHero);

        }

        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com sua espada";
        }
    }
}