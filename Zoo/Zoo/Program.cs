using System;

namespace Zoo
{
    class Program
    {
        /// <summary>
        /// Entry-point to our program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our zoo!");
            Console.WriteLine("We have birds, fish, and mammals!");
            Console.WriteLine("Introducing the birds (after you press a key)!");
            Console.ReadKey();

            PresentBirds();

            Console.WriteLine("\nPlease press a key to see our fish...");
            Console.ReadKey();

            PresentFish();

            Console.WriteLine("\nPlease press a key to see our mammals...");
            Console.ReadKey();

            PresentMammals();

            Console.WriteLine("\nPlease press a key for some closing words...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thank you for visiting our zoo!");
            Console.WriteLine("I hope this inspired you to look out for all the creatures we share");
            Console.WriteLine("this planet with. They truly are amazing!");

            Console.WriteLine("\nPlease press a key to exit the zoo...");
            Console.ReadKey();
        }

        /// <summary>
        /// Writes a list of birds in the zoo and has them perform actions
        /// </summary>
        static void PresentBirds()
        {
            Console.Clear();
            Console.WriteLine("First, our flying birds!");
            Console.WriteLine("These birds are commonly found in our backyards...");

            Animals.Birds.Flying.Robin robin = new Animals.Birds.Flying.Robin();
            Console.WriteLine($"This is a {robin.Name}.");
            Console.WriteLine(robin.Hunt());
            Console.WriteLine(robin.Eat());
            Console.WriteLine(robin.Molt());
            Console.WriteLine(robin.Move());

            Animals.Birds.Flying.Sparrow sparrow = new Animals.Birds.Flying.Sparrow();
            Console.WriteLine($"\n...and this is a {sparrow.Name}");
            Console.WriteLine(sparrow.Speak());
            Console.WriteLine(sparrow.Molt());
            Console.WriteLine($"The sparrow has {sparrow.Wings} wings.");
            Console.WriteLine(sparrow.Move());

            Console.WriteLine("\nPress a key to see our raptors...");
            Console.ReadKey();
            Console.Clear();

            Animals.Birds.Flying.Raptor.Eagle eagle = new Animals.Birds.Flying.Raptor.Eagle();
            Console.WriteLine($"Our first raptor is the {eagle.Name}!");
            Console.WriteLine(eagle.Hunt());
            Console.WriteLine(eagle.Eat());
            Console.WriteLine(eagle.Speak());
            Console.WriteLine(eagle.Move());

            Animals.Birds.Flying.Raptor.Hawk hawk = new Animals.Birds.Flying.Raptor.Hawk();
            Console.WriteLine($"\nHere is the {hawk.Name}!");
            Console.WriteLine(hawk.Molt());
            Console.WriteLine(hawk.Move());

            Console.WriteLine("\nPress a key to see our grounded birds...");
            Console.Clear();

            Animals.Birds.Grounded.Ostrich ostrich = new Animals.Birds.Grounded.Ostrich();
            Console.WriteLine($"Our first grounded bird, the {ostrich.Name} can be found in Australia.");
            Console.WriteLine(ostrich.Speak());
            Console.WriteLine(ostrich.Move());
            Console.WriteLine(ostrich.Hunt());
            Console.WriteLine(ostrich.Eat());

            Animals.Birds.Grounded.Dodo dodo = new Animals.Birds.Grounded.Dodo();
            Console.WriteLine($"\nOur {dodo.Name} doesn't do much anymore. Its kind has become extinct");
            Console.WriteLine(dodo.Speak());
            Console.WriteLine(dodo.Molt());
            Console.WriteLine(dodo.Move());
            Console.WriteLine($"The {dodo.Name} is now {(dodo.CheckPulse() ? "alive" : "dead, unfortunately.")}");
        }

        /// <summary>
        /// Writes a list of fish in the zoo and has them perform actions
        /// </summary>
        static void PresentFish()
        {
            Console.Clear();
            Console.WriteLine("We have freshwater and saltwater fish here.");
            Console.WriteLine("First, we will look at the freshwater fish...");

            Animals.Fish.Freshwater.Bass bass = new Animals.Fish.Freshwater.Bass();
            Console.WriteLine($"\nThis is the {bass.Name}");
            Console.WriteLine(bass.Move());
            Console.WriteLine($"It has {bass.Legs} legs being a fish.");
            Console.WriteLine(bass.Eat());
            Console.WriteLine(bass.Molt());
            Console.WriteLine(bass.Speak());

            Animals.Fish.Freshwater.Bluegill bluegill = new Animals.Fish.Freshwater.Bluegill();
            Console.WriteLine($"\nAnd now for the {bluegill.Name}!");
            Console.WriteLine(bluegill.Speak());
            Console.WriteLine(bluegill.Eat());
            Console.WriteLine(bluegill.Move());

            Console.WriteLine("\nPlease press a key to see our saltwater fish...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("And now for our saltwater fish...");

            Animals.Fish.Saltwater.Sardine sardine = new Animals.Fish.Saltwater.Sardine();
            Console.WriteLine($"\nThis {sardine.Name} can be found on your pizza.");
            Console.WriteLine(sardine.Move());
            Console.WriteLine(sardine.Speak());
            Console.WriteLine(sardine.Molt());
            Console.WriteLine(sardine.Eat());

            Animals.Fish.Saltwater.TigerShark tigerShark = new Animals.Fish.Saltwater.TigerShark();
            Console.WriteLine($"\nThe {tigerShark.Name} would eat the {sardine.Name} if given a chance!");
            Console.WriteLine(tigerShark.Eat());
            Console.WriteLine(tigerShark.Molt());
            Console.WriteLine(tigerShark.Move());
        }

        /// <summary>
        /// Writes a list of mammals in the zoo and has them perform actions
        /// </summary>
        static void PresentMammals()
        {
            Console.Clear();
            Console.WriteLine("Finally, we have the mammals!");
            Console.WriteLine("This first type of mammal is the rodent.");

            Animals.Mammal.Rodent.Mouse mouse = new Animals.Mammal.Rodent.Mouse();
            Console.WriteLine($"\nThis {mouse.Name} is one you may have seen in your kitchen.");
            Console.WriteLine($"It has {mouse.Legs} legs.");
            Console.WriteLine(mouse.Speak());
            Console.WriteLine(mouse.Move());
            Console.WriteLine(mouse.Eat());

            Animals.Mammal.Rodent.Chipmunk chipmunk = new Animals.Mammal.Rodent.Chipmunk();
            Console.WriteLine($"\nThe {chipmunk.Name} can be found among trees and in parks.");
            Console.WriteLine(chipmunk.Move());
            Console.WriteLine(chipmunk.Molt());
            Console.WriteLine(chipmunk.Speak());
            Console.WriteLine(chipmunk.Eat());
            Console.WriteLine($"The {chipmunk.Name} has fur {chipmunk.FurLength} cm long.");

            Console.WriteLine("\nPlease press a key to see the felines...");
            Console.ReadKey();
            Console.Clear();

            Animals.Mammal.Feline.Cat cat = new Animals.Mammal.Feline.Cat();
            Console.WriteLine($"Our first feline, the {cat.Name} is a common household pet.");
            Console.WriteLine(cat.Speak());
            Console.WriteLine(cat.Move());
            Console.WriteLine(cat.Eat());
            Console.WriteLine($"The cat has {cat.Legs} legs and fur {cat.FurLength} cm long.");

            Animals.Mammal.Feline.Lion lion = new Animals.Mammal.Feline.Lion();
            Console.WriteLine($"\nThis {lion.Name} is known as the king of the jungle!");
            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Molt());
            Console.WriteLine(lion.Move());
            Console.WriteLine(lion.Speak());
            Console.WriteLine($"The {lion.Name} has {lion.Legs} legs and fur {lion.FurLength} cm long.");
        }
    }
}
