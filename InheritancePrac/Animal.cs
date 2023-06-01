using System;
namespace InheritancePrac
{
    public class Animal
    {
        public Animal() {  this.Age = 0; }

        public Animal(int age)
        {
            this.Age = age;
        }
        public int Age { get; set; }

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