namespace PolymorphismInheritance
{
    public class Gorilla : Animal
    {
        // Constructors
        public Gorilla(string name) 
        {
            this.name = name;
            this.lifeSpan = 38;
            this.isExtinct = false;
            this.numberOfLegs = 2;
        }

        // Methods
        public override void doSound()
        {
            Console.WriteLine("The gorilla does: oouh oouh\n");
        }

        public override void displayDescription()
        {
            Console.WriteLine("Gorilla:");
            Console.WriteLine("=========");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Life span: " + this.lifeSpan + " years");
            Console.WriteLine("Is extinct ?: " + this.isExtinct.ToString());
            Console.WriteLine("Number of legs: " + this.numberOfLegs);
            doSound();
        }
    }
}
