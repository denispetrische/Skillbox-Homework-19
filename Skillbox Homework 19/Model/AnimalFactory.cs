using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Skillbox_Homework_19.Model.Animals;
using System.Diagnostics;

namespace Skillbox_Homework_19.Model
{
    static class AnimalFactory
    {
        static List<Type> types = new List<Type>() { typeof(Amphibian), 
                                                     typeof(Bird),
                                                     typeof(Mammal)
         };

        public static IAnimal ProduceAnimal(string type, string name, int age, string colour)
        {
            IAnimal temp = new DefaultAnimal() { Name = "qwer", Age = 2, Colour = "Black"};

            

            return temp;
        }
    }
}
