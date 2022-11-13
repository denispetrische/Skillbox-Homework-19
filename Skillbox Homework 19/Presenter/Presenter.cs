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
            model.AddNewAnimal("qwer","qwer",1,"qwer");
        }

        public void DeletePressed()
        {

        }

        public void EditPressed()
        {

        }

        public void SavePressed()
        {

        }

        private void UpdateView(List<IAnimal> animals)
        {
            System.Diagnostics.Debug.WriteLine("Here");

            foreach (var item in animals)
            {
                System.Diagnostics.Debug.WriteLine($"{item.Name} {item.Age} {item.Colour}");
            }

            view.UpdateListView(animals);
        }
    }
}
