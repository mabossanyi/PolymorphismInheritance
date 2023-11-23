namespace PolymorphismInheritance
{
    public class Dodo : Animal
    {
        // Constructors
        public Dodo(string name)
        {
            this.name = name;
            this.lifeSpan = 20;
            this.isExtinct = true;
            this.numberOfLegs = 2;
        }

        // Methods 
        public override void doSound()
        {
            Console.WriteLine("The dodo does: ca ca caw\n");
        }

        public override void displayDescription()
        {
            Console.WriteLine("Dodo:");
            Console.WriteLine("======");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Life span: " + this.lifeSpan + " years");
            Console.WriteLine("Is extinct ?: " + this.isExtinct.ToString());
            Console.WriteLine("Number of legs: " + this.numberOfLegs);
            doSound();
        }
    }
}
