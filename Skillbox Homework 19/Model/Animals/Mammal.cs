using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework_19.Model.Animals
{
    class Mammal : IAnimal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Colour { get; set; }
    }
}
