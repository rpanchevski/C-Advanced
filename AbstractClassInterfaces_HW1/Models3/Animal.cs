using Models3.Interfaces;

namespace Models3
{
    public abstract class Animal : IAnimal
    {
       public string Name { get; set; }
       public string Breed { get; set; }
       public int Age { get; set; }
  

        public Animal(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
        public virtual string PrintAnimal()
        {
            return $"{Name} is of type {Breed}. Age: {Age}. ";
        }
    }
}
