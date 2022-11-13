using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillbox_Homework_19.Model.Animals;

namespace Skillbox_Homework_19.Model
{
    class DefaultAnimal : IAnimal
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public string Colour { get; set; }
    }
}
