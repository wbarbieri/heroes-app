namespace proj_C.src.Entities

{
    class Program
    {
        static void Main(string[]args)
        {
            Knight knight = new Knight ("Arus", 42, "Knight");
            Wizard wizard = new Wizard ("Jennica", 42, "White Wizard");
            Ninja ninja = new Ninja ("Wedge", 42, "Ninja");
            BWizard bWizard = new BWizard ("Topapa", 42, "Black Wizard");


            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(knight.Attack(5));
            Console.WriteLine(ninja.Attack(8));
            Console.WriteLine(bWizard.Attack(6));
        }
    }
    
}