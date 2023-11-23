namespace PolymorphismInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("Bob", 80, false, 4);
            Animal cat = new Cat("Sylvester");
            Animal dog = new Dog("Gunther");
            Animal gorilla = new Gorilla("Matt");
            Animal dodo = new Dodo("Didier");

            Console.WriteLine("Test for 'Animal'...");
            animal.displayDescription();

            Console.WriteLine("Test for 'Cat'...");
            cat.displayDescription();

            Console.WriteLine("Test for 'Dog'...");
            dog.displayDescription();

            Console.WriteLine("Test for 'Gorilla'...");
            gorilla.displayDescription();

            Console.WriteLine("Test for 'Dodo'...");
            dodo.displayDescription();
        }
    }
}
