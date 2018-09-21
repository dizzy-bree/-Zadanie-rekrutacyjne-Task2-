using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public static int count = 0;
        public Dog()
        {
            count++;
        }

        public void Speak()
        {
            Console.WriteLine("Bark-bark!");
        }
    }

    public class Cat : IAnimal
    {
        public static int count = 0;
        public Cat()
        {
            count++;
        }

        public void Speak()
        {
            Console.WriteLine("Meow-meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {  
            List<IAnimal> animals = new List<IAnimal>
           {
               new Dog(),
               new Dog(),
               new Dog(),
               new Dog(),
               new Dog(),
               new Cat(),
               new Cat(),
               new Cat()
           };

            PrintNrInPopulation(animals);

           // Dog checkSpeak = new Dog();
            //checkSpeak.Speak();

            void PrintNrInPopulation(ICollection<IAnimal> animalList)
            {

                Console.WriteLine("There are "+animalList.Count + " animals");
                Console.WriteLine("There are " + Dog.count + " dogs and " + Cat.count + " cats");
            }
        }
    }
}
