using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillbox_Homework_19.Model;
using Skillbox_Homework_19.Model.Animals;
using System.Diagnostics;

namespace Skillbox_Homework_19
{
    public delegate void ViewUpdateHandler(List<IAnimal> animals);

    class ModelClass : IModel
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public delegate void ViewUpdateHandler(List<IAnimal> animals);
        public event IModel.ViewUpdateHandler UpdateNeed = delegate { };


        public void AddNewAnimal(string type, string name, int age, string colour)
        {
            animals.Add(AnimalFactory.ProduceAnimal(type,name,age,colour));

            UpdateNeed?.Invoke(animals);
        }

        public void DeleteAnimal()
        {

        }

        public void EditAnimal()
        {

        }

        public void SaveAnimalInfo()
        {

        }
    }
}
