namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal zebra = new Zebra("Zuper Zebran", 4, false); // Skapar olika djur
            Animal dolphin = new Dolphin("Flipper", 7, "Grå");
            Animal flamingo = new Flamingo("Pink", 5, true);
            Animal orca = new Orca("Shamu", 12, "svart/vit", true);
            Animal whale = new Whale("Mini", 22, "Ljusgrå", 5);

            zebra.makeSound(); // Anropar makeSound metoden för alla djur
            dolphin.makeSound();
            flamingo.makeSound();
            orca.makeSound();
            whale.makeSound();
        }
    }

    public class Animal
    {
        public string Name { get; set; } // Egenskaper för alla djur
        public int Age { get; set; }
        public string Species { get; set; }
        public bool Fur { get; set; }
        public string Diet { get; set; }

        public Animal(string name, int age, string species, bool fur, string diet)
        {
            Name = name; // Sätter egenskaper för alla djur
            Age = age;
            Species = species;
            Fur = fur;
            Diet = diet;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("Djurläte.");
        }

        public void eat()
        {
            Console.WriteLine("Djuret äter.");
        }

        public void sleep()
        {
            Console.WriteLine("Djuret sover.");
        }
    }
    public class Zebra : Animal // Ärver från Animal
    {
        public bool Hashorseshoe { get; set; } // Egenskap för just Zebra

        public Zebra(string name, int age, bool hasHorseshoe)
            : base(name, age, "Zebra", true, "Växtätare")
        {
            Hashorseshoe = hasHorseshoe;
        }

        public void run()
        {
            Console.WriteLine("Zebran springer förbi!");
        }
        public override void makeSound() // Åsidosätter makeSound metoden från basklassen 
        {
            Console.WriteLine("Gnägg.");
        }

    }
    public class Dolphin : Animal
    {
        public string Color { get; set; }

        public Dolphin(string name, int age, string color)
            : base(name, age, "Delfin", false, "Köttätare")
        {
            Color = color;
        }

        public virtual void jump()
        {
            Console.WriteLine("Delfinen hoppar ur genom ringen.");
        }

        public override void makeSound()
        {
            Console.WriteLine("Klickande!");
        }
    }
    public class Flamingo : Animal
    {
        public bool Wingclipped { get; set; }

        public Flamingo(string name, int age, bool wingClipped)
            : base(name, age, "Flamingo", false, "Allätare")
        {
            Wingclipped = wingClipped;
        }

        public void standOneLeg()
        {
            Console.WriteLine("Flamingon står på ett ben.");
        }

        public override void makeSound()
        {
            Console.WriteLine("Honk!");
        }
    }

    public class Orca : Dolphin // Ärver från Dolphin
    {
        public bool Curvedfin { get; set; }

        public Orca(string name, int age, string color, bool curvedFin)
            : base(name, age, color)
        {
            Curvedfin = curvedFin;
        }

        public override void jump() // Åsidosätter jump metoden från Dolphin
        {
            Console.WriteLine("Späckhuggaren hoppar up ur vattnet!");
        }
    }

    public class Whale : Dolphin
    {
        public int Scars { get; set; }

        public Whale(string name, int age, string color, int scars)
            : base(name, age, color)
        {
            Scars = scars;
        }

        public override void jump()
        {
            Console.WriteLine("Valen hoppar ur vattnet och skvätter ner alla i närheten!");
        }
    }
}