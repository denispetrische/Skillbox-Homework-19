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
using Skillbox_Homework_19.View;

namespace Skillbox_Homework_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        AddWindow addWindow;
        EditWindow editWindow;
        SaveWindow saveWindow;

        Presenter presenter;

        public List<IAnimal> ItemsSource { set => this.listview.ItemsSource = value; }

        public int SelectedItemNumber { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Colour { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            this.ContextItemAdd.Click += (s, e) => AddPressed(s,e);
            this.ContextItemEdit.Click += (s, e) => EditPressed(s,e);
            this.ContextItemSave.Click += (s, e) => SavePressed(s,e);

            this.ContextItemDelete.Click += (s, e) => DeletePressed(s,e);
        }

        public void UpdateListView(List<IAnimal> animals)
        {
            this.listview.ItemsSource = null;
            this.listview.ItemsSource = animals;
        }

        public void AddPressed(object sender, RoutedEventArgs e)
        {
            addWindow = new AddWindow();
            addWindow.buttonAdd.Click += (s, e) => AddWindowButtonClicked(s, e);
            addWindow.Show();
        }

        public void AddWindowButtonClicked(object sender, RoutedEventArgs e)
        {
            Type = addWindow.textboxType.Text;
            Name = addWindow.textboxName.Text;
            Age = addWindow.textboxAge.Text;
            Colour = addWindow.textboxColour.Text;

            presenter.AddPressed();

            addWindow.Close();
        }

        public void EditPressed(object sender, RoutedEventArgs e)
        {
            editWindow = new EditWindow();
            editWindow.buttonEdit.Click += (s, e) => EditWindowButtonPressed(s, e);
            editWindow.Show();
        }

        public void EditWindowButtonPressed(object sender, RoutedEventArgs e)
        {
            Name = editWindow.textboxName.Text;
            Age = editWindow.textboxAge.Text;
            Colour = editWindow.textboxColour.Text;

            presenter.EditPressed();

            editWindow.Close();
        }

        public void DeletePressed(object sender, RoutedEventArgs e)
        {
            SelectedItemNumber = listview.SelectedIndex;
        }

        public void SavePressed(object sender, RoutedEventArgs e)
        {
            saveWindow = new SaveWindow();
            saveWindow.buttonSaveTXT.Click += (s, e) => SaveWindowButtonTxtPressed(s, e);
            saveWindow.buttonSaveXLS.Click += (s, e) => SaveWindowButtonXlsPressed(s, e);
            saveWindow.buttonSavePDF.Click += (s, e) => SaveWindowButtonPdfPressed(s, e);
            saveWindow.Show();
        }

        public void SaveWindowButtonTxtPressed(object sender, RoutedEventArgs e)
        {
            presenter.SaveTxt();
            saveWindow.Close();
        }

        public void SaveWindowButtonXlsPressed(object sender, RoutedEventArgs e)
        {
            presenter.SaveXls();
            saveWindow.Close();
        }

        public void SaveWindowButtonPdfPressed(object sender, RoutedEventArgs e)
        {
            presenter.SavePdf();
            saveWindow.Close();
        }

        public void MessageShow(string message)
        {
            MessageBox.Show(message);
        }
    }
}
