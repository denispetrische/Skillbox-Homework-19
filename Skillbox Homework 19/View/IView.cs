using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillbox_Homework_19.Model.Animals;

namespace Skillbox_Homework_19
{
    interface IView
    {
        public List<IAnimal> ItemsSource { set; }

        public int SelectedItemNumber { get; }

        public void UpdateListView(List<IAnimal> animals);
    }
}
