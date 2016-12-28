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
    /// Логика взаимодействия для ListPatient.xaml
    /// </summary>
    public partial class ListPatient : Window
    {
        private PatientViewModel _viewModel;

        protected PatientViewModel ViewModel
        {
            get { return _viewModel ?? (_viewModel = DataContext as PatientViewModel); }
        }

        public ListPatient()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window_Loaded);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Load();
            ListBoxView.ItemsSource = ViewModel.listPatient;
        }

        private void Load()
        {
            ListBoxView.Items.Clear();//clear listbox

            using (var db = new AutoDataContext())//load values into listbox
            {
                var query = from item in db.Patient
                            orderby item.lastName, item.firstName, item.middleName
                            select new
                            {
                                id = item.id,
                                firstName   = item.firstName,
                                lastName    = item.lastName,
                                middleName  = item.middleName,
                                gender      = item.gender,
                                phoneNumber = item.phoneNumber
                            }
                           ;

                var arr = query.ToArray();

                foreach (var record in arr)
                {
                    Patient lst = new Patient(  record.id
                                                , record.lastName + " " + record.firstName + " " + record.middleName
                                                , record.gender
                                                , record.phoneNumber
                                                );
                    ListBoxView.Items.Add(lst);
                }
            }
        }

        private void Add()
        {
            //Show window Add patient
            NewPatient AddPatientWindow = new NewPatient();
            AddPatientWindow.Owner = this;
            AddPatientWindow.ShowDialog();

            ViewModel.Load();
        }

        private void Edit()
        {
            if (ListBoxView.Items.Count == 0) return;
            object ob = ListBoxView.SelectedItem;

            //if do not selected value return
            if (ob == null) return;

            int id = (ob as Patient).id;
            Param.id = id;
            Param.lastWindow = "ListPatient";

            //Show window edit patient
            NewPatient AddPatientWindow = new NewPatient();
            AddPatientWindow.Owner = this;
            AddPatientWindow.ShowDialog();

            ViewModel.Load();
        }

        private void Delete()
        {
            if (ListBoxView.Items.Count == 0) return;
            object ob = ListBoxView.SelectedItem;

            //if do not select value return
            if (ob == null) return;

            int id = (ob as Patient).id;

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
