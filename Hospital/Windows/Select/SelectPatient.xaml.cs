using Hospital.Model;
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
    /// Логика взаимодействия для SelectPatientWindow.xaml
    /// </summary>
    public partial class SelectPatient : Window
    {
        private PatientViewModel _viewModel;

        protected PatientViewModel ViewModel
        {
            get { return _viewModel ?? (_viewModel = DataContext as PatientViewModel); }
        }

        public SelectPatient()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(Window_Loaded);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Load();
            ListBoxView.ItemsSource = ViewModel.listPatient;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxView.Items.Count == 0) return;
            object ob = ListBoxView.SelectedItem;

            //if do not select value return
            if (ob == null) return;

            int id = (ob as Patient).id;

            Param.lastWindow = "SelectPatient";
            Param.id = id;

            Close();
        }
    }
}
