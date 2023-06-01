using System;

namespace InheritancePrac
{
    public class Cat
    {
        public int Age { get; set; }

        public Cat() { this.Age = 0; }

        public void Meow()
        {
            Console.WriteLine("야옹");
        }

        public void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
    }
}