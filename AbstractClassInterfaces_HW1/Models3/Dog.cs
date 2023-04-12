using Models3.Interfaces;

namespace Models3
{
    public class Dog : Animal, IDog
    {
        public string Color { get; set; }
        public Dog(string name, string type, int age, string color) :
            base(name, type, age)
        {
            Color = color;
        }

        public virtual string PrintAnimal()
        {
            return base.PrintAnimal() + $"Is colored {Color}";
        }
        public string Bark()
        {
            return "Aw Aw Aw...";
        }
    }
    
}
