using Hospital.Model;
using Hospital.SQL;
using Hospital.ViewModel;
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
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для ListReception.xaml
    /// </summary>
    public partial class ListReception : Window
    {
        Patients patient;

        public ListReception()
        {
            InitializeComponent();

            patient = new Patients();
            this.Loaded += new RoutedEventHandler(Window_Loaded);
        }

        private ReceptionViewModel _viewModel;

        protected ReceptionViewModel ViewModel
        {
            get { return _viewModel ?? (_viewModel = DataContext as ReceptionViewModel); }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Load();
            ListBoxView.ItemsSource = ViewModel.listReception;
        }

        private void Add()
        {
            //Show window Add patient
            NewReception AddReceptionWindow = new NewReception();
            AddReceptionWindow.Owner = this;
            AddReceptionWindow.ShowDialog();

            ViewModel.Load();
        }

        private void Edit()
        {
            if (ListBoxView.Items.Count == 0) return;
            object ob = ListBoxView.SelectedItem;

            //if do not selected value return
            if (ob == null) return;

            int id = (ob as Reception).id;
            Param.id = id;
            Param.lastWindow = "ListReception";

            //Show window edit patient
            NewReception AddReceptionWindow = new NewReception();
            AddReceptionWindow.Owner = this;
            AddReceptionWindow.ShowDialog();

            ViewModel.Load();
        }

        private void Delete()
        {
            if (ListBoxView.Items.Count == 0) return;
            object ob = ListBoxView.SelectedItem;

            //if do not select value return
            if (ob == null) return;

            int id = (ob as Reception).id;

            ViewModel.Delete(id);
            ViewModel.Load();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Edit();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Add();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
    }
}
