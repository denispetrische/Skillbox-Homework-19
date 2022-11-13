using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillbox_Homework_19.Model;
using Skillbox_Homework_19.Model.Animals;

namespace Skillbox_Homework_19
{
    class Presenter
    {
        IView view;
        IModel model;

        public Presenter(IView view)
        {
            this.view = view;
            model = new ModelClass();

            model.UpdateNeed += new IModel.ViewUpdateHandler(UpdateView);
        }

        public void AddPressed()
        {
            if (view.Type == "" || view.Name == "" || view.Age == "" || view.Colour == "")
            {
                view.MessageShow("Все поля должны быть заполнены");
            }
            else
            {
                model.AddNewAnimal(view.Type, view.Name, view.Age, view.Colour);
            }
        }

        public void DeletePressed()
        {

        }

        public void EditPressed()
        {
            if (view.Name == "" || view.Age == "" || view.Colour == "")
            {
                view.MessageShow("Все поля должны быть заполнены");
            }
            else
            {
                model.EditAnimal();
            }
        }

        public void SaveTxt()
        {
            if (view.SelectedItemNumber == null)
            {
                view.MessageShow("Выберите элемент списка");
            }
            else
            {
                model.SaveTxt(view.SelectedItemNumber);
            }           
        }

        public void SaveXls()
        {
            if (view.SelectedItemNumber == null)
            {
                view.MessageShow("Выберите элемент списка");
            }
            else
            {
                model.SaveXls(view.SelectedItemNumber);
            }
        }

        public void SavePdf()
        {
            if (view.SelectedItemNumber == null)
            {
                view.MessageShow("Выберите элемент списка");
            }
            else
            {
                model.SavePdf(view.SelectedItemNumber);
            }
        }

        private void UpdateView(List<IAnimal> animals)
        {
            foreach (var item in animals)
            {
                System.Diagnostics.Debug.WriteLine($"{item.Name} {item.Age} {item.Colour}");
            }

            view.UpdateListView(animals);
        }
    }
}
