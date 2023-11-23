namespace PolymorphismInheritance
{
    public class Animal
    {
        // Attributes 
        protected string name;
        protected int lifeSpan;
        protected bool isExtinct;
        protected int numberOfLegs;

        // Constructors
        public Animal()
        {
            this.name = string.Empty;
            this.lifeSpan = 0;
            this.isExtinct = false;
            this.numberOfLegs = 0;
        }

        public Animal(string name, int lifeSpan, bool isExtinct, int numberOfLegs)
        {
            this.name = name;
            this.lifeSpan = lifeSpan;
            this.isExtinct = isExtinct;
            this.numberOfLegs = numberOfLegs;
        }

        // Getters 
        public string getName()
        {
            return this.name;   
        }

        public int getLifeSpan()
        {
            return this.lifeSpan;
        }

        public bool getIsExtinct()
        { 
            return this.isExtinct; 
        }

        public int getNumberOfLegs()
        {
            return this.numberOfLegs;
        }

        // Setters
        public void setName(string name)
        {
            this.name = name;
        }

        public void setLifeSpan(int lifeSpan)
        {
            this.lifeSpan = lifeSpan;
        }

        public void setIsExtinct(bool isExtinct)
        {
            this.isExtinct = isExtinct;
        }

        public void setNumberOfLegs(int numberOfLegs)
        {
            this.numberOfLegs = numberOfLegs;
        }

        // Methods
        public virtual void doSound()
        {
            Console.WriteLine("The animal does: ...\n");
        }

        public virtual void displayDescription()
        {
            Console.WriteLine("Animal:");
            Console.WriteLine("========");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Life span: " + this.lifeSpan + " years");
            Console.WriteLine("Is extinct ?: " + this.isExtinct.ToString());
            Console.WriteLine("Number of legs: " + this.numberOfLegs);
            doSound();
        }

    }
}
