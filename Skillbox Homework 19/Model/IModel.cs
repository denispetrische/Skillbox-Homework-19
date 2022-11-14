using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillbox_Homework_19;
using Skillbox_Homework_19.Model.Animals;

namespace Skillbox_Homework_19
{
    public interface IModel
    {
        public delegate void ViewUpdateHandler(List<IAnimal> animals);

        public event ViewUpdateHandler UpdateNeed;

        public void AddNewAnimal(string type, string name, string age, string colour);

        public void DeleteAnimal(int index);

        public void EditAnimal(int index, string name, string age, string colour);

        public void SaveTxt(int number);

        public void SavePdf(int number);

        public void SaveXls(int number);
    }
}
