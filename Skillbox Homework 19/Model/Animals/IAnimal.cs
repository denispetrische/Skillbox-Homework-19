﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework_19.Model.Animals
{
    public interface IAnimal
    {
        public ISaver SaveMode { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Colour { get; set; }
    }
}
