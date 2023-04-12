using Models3.Interfaces;

namespace Models3
{
    public class Cat : Animal, ICat
    {
        public TailTypeEnum TailType { get; set; }
        public Cat(string name, string breed, int age, TailTypeEnum tailType) :
            base(name, breed, age)
        {
             TailType = tailType;
        }

        public virtual string PrintAnimal()
        {
            return base.PrintAnimal() + $"Tail: {TailType}";
        }
        public string Eat(string foodType)
        {
            return $"{Name}'s favourite food is : {foodType}";
        }
    }
}
