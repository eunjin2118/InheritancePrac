using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(), 
                new Cat(), new Cat(), new Cat() };


            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                var _dog = item as Dog;
                if (item is Dog)
                {
                    _dog.Bark();
                } else if(item is Cat) {
                    var _cat = ((Cat)item);
                    _cat.Meow();
                }
             
            }
        }
    }
}
