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


        public void AddNewAnimal(string type, string name, string age, string colour)
        {
            animals.Add(AnimalFactory.ProduceAnimal(type,name,age,colour));

            UpdateNeed?.Invoke(animals);
        }

        public void DeleteAnimal(int index)
        {
            animals.Remove(animals[index]);

            UpdateNeed?.Invoke(animals);
        }

        public void EditAnimal(int index, string name, string age, string colour)
        {
            animals[index].Name = name;
            animals[index].Age = age;
            animals[index].Colour = colour;

            UpdateNeed?.Invoke(animals);
        }

        public void SaveTxt(int number)
        {
            animals[number].SaveMode = new TxtSaver();
            animals[number].SaveMode.Save(animals[number].Name, animals[number].Age, animals[number].Colour);
        }

        public void SaveXls(int number)
        {
            animals[number].SaveMode = new XlsSaver();
            animals[number].SaveMode.Save(animals[number].Name, animals[number].Age, animals[number].Colour);
        }

        public void SavePdf(int number)
        {
            animals[number].SaveMode = new PdfSaver();
            animals[number].SaveMode.Save(animals[number].Name, animals[number].Age, animals[number].Colour);
        }
    }
}
