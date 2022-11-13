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

        public static IAnimal ProduceAnimal(string type, string name, string age, string colour)
        {
            foreach (Type sometype in types)
            {
                Debug.WriteLine(sometype.Name);
                Debug.WriteLine(type);

                if (sometype.Name == type)
                {
                    var myAnimal = (IAnimal)Activator.CreateInstance(sometype);
                    myAnimal.Name = name;
                    myAnimal.Age = age;
                    myAnimal.Colour = colour;

                    return myAnimal;
                }
            }

            IAnimal temp = new DefaultAnimal() { Name = "Default", Age = "0", Colour = "Default"};             
            return temp;
        }
    }
}
