using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Skillbox_Homework_19.Model;
using Skillbox_Homework_19.Model.Animals;

namespace Skillbox_Homework_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter presenter;

        public List<IAnimal> ItemsSource { set => this.listview.ItemsSource = value; }

        public int SelectedItemNumber { get => this.listview.SelectedIndex; }

        public MainWindow()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            this.ContextItemAdd.Click += (s, e) => presenter.AddPressed();
            this.ContextItemDelete.Click += (s, e) => presenter.DeletePressed();
            this.ContextItemEdit.Click += (s, e) => presenter.EditPressed();
            this.ContextItemSave.Click += (s, e) => presenter.SavePressed();
        }

        public void UpdateListView(List<IAnimal> animals)
        {
            this.listview.ItemsSource = null;
            this.listview.ItemsSource = animals;
        }
    }
}
