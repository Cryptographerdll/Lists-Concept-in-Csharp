using System;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Uses_OF_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animales = new List<Animal>();
            Animales.Add(new Animal("Panda", 25));
            Animales.Add(new Animal("Monkey", 10));
            Animales.Add(new Animal("Dankey", 30));

            foreach (var animal in Animales)
            {
                Console.WriteLine($"Name: {animal.name} & Age: {animal.age}");
            }
        }
    }
}
