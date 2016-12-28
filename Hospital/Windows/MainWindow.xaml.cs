using Hospital.Windows;
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

namespace Hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var db = new AutoDataContext())
            {
                //db.Database.Delete();//на время разарботки пересоздаем БД всегда
                //db.Database.CreateIfNotExists();
                //if (db.Database.Exists() == false)
                //{
                //    db.Database.Create();
                //}
            }
            //DbDatabase.SetInitializer(new DropCreateDatabaseIfModelChanges<AutoDataContext>());
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonListPatient_Click(object sender, RoutedEventArgs e)
        {
            ListPatient ListPatienttWindow = new ListPatient();
            ListPatienttWindow.Owner = this;
            ListPatienttWindow.ShowDialog();
        }

        private void ButtonReception_Click(object sender, RoutedEventArgs e)
        {
            ListReception ListReceptionWindows = new ListReception();
            ListReceptionWindows.Owner = this;
            ListReceptionWindows.ShowDialog();
        }
    }
}
