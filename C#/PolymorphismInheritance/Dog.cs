namespace PolymorphismInheritance
{
    public class Dog : Animal
    {
        // Constructors
        public Dog(string name) 
        {
            this.name = name;
            this.lifeSpan = 12;
            this.isExtinct = false;
            this.numberOfLegs = 4;
        }

        // Methods 
        public override void doSound()
        {
            Console.WriteLine("The dog does: woof woof\n");
        }

        public override void displayDescription()
        {
            Console.WriteLine("Dog:");
            Console.WriteLine("=====");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Life span: " + this.lifeSpan + " years");
            Console.WriteLine("Is extinct ?: " + this.isExtinct.ToString());
            Console.WriteLine("Number of legs: " + this.numberOfLegs);
            doSound();
        }
    }
}
