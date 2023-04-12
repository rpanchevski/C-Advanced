using System.Data.Common;
using Models3;
using Models3.Interfaces;

namespace Homework_class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Max", "German Shepherd", 4, "brown");
            Dog d2 = new Dog("Lily", "Bichon Frise", 5, "white");
            Dog d3 = new Dog("Bella", "Retriever", 3, "gold");

            Cat c1 = new Cat("Tom", "Persian", 3, TailTypeEnum.Short);
            Cat c2 = new Cat("Boo", "Ragdoll", 7, TailTypeEnum.Long);
            Cat c3 = new Cat("Smokey", "Birman", 2, TailTypeEnum.Short);

            Console.WriteLine(d1.PrintAnimal());
            Console.WriteLine(d1.Bark());
            Console.WriteLine(d2.PrintAnimal());
            Console.WriteLine(d3.PrintAnimal());

            Console.WriteLine(c1.PrintAnimal());
            Console.WriteLine(c1.Eat("beef"));
            Console.WriteLine(c2.PrintAnimal());
            Console.WriteLine(c2.Eat("bones"));
            Console.WriteLine(c3.PrintAnimal());
            Console.WriteLine(c3.Eat("cheese"));

        }
    }
}