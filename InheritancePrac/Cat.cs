using System;

namespace InheritancePrac
{
    public class Cat : Animal
    {
        public Cat() { this.Age = 0; }

        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
}