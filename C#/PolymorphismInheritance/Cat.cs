namespace PolymorphismInheritance
{
    public class Cat : Animal
    {
        // Constructors
        public Cat(string name)
        {
            this.name = name;
            this.lifeSpan = 14;
            this.isExtinct = false;
            this.numberOfLegs = 4;
        }

        // Methods
        public override void doSound()
        {
            Console.WriteLine("The cat does: miaw miaw\n");
        }

        public override void displayDescription()
        {
            Console.WriteLine("Cat:");
            Console.WriteLine("=====");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Life span: " + this.lifeSpan + " years");
            Console.WriteLine("Is extinct ?: " + this.isExtinct.ToString());
            Console.WriteLine("Number of legs: " + this.numberOfLegs + "\n");
        }
    }
}
