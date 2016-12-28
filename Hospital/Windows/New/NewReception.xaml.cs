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
using Hospital.SQL;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewPeception.xaml
    /// </summary>
    public partial class NewReception : Window
    {
        Patients patient;

        public NewReception()
        {
            InitializeComponent();

            patient = new Patients();
            DatePicker.SelectedDate = DateTime.Today;

            Load();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            double cost;
            double.TryParse(TextBoxCost.Text, out cost);

            string completedWork = new TextRange(RichEditCompletedWork.Document.ContentStart, RichEditCompletedWork.Document.ContentEnd).Text;

            string lastWindows = Param.lastWindow == null ? "" : Param.lastWindow;
            if (lastWindows.Equals("ListReception"))
            {
                if (Receptions.UpdateItem(Param.id, patient, cost, DatePicker.DisplayDate, completedWork))
                    Close();
            }
            else
            {
                if (Receptions.NewItem(patient, cost, DatePicker.DisplayDate, completedWork))
                    Close();
            }
        }

        private void ButtonSelectPatient_Click(object sender, RoutedEventArgs e)
        {
            //select patient
            SelectPatient SelectPatientWindow = new SelectPatient();
            SelectPatientWindow.Owner = this;
            SelectPatientWindow.ShowDialog();

            if (Param.lastWindow != null)
                if (Param.lastWindow.Equals("SelectPatient") & Param.id > 0)
                {
                    patient = Patients.GetItem(Param.id);
                    TextBoxPatient.Text = patient.firstName + " " + patient.lastName + " " + patient.middleName;
                }
        }

        private void Load()
        {
            if (Param.lastWindow != null)
                if (Param.lastWindow.Equals("ListReception"))
                {
                    ButtonAdd.Content = "Обновить"; //change name button

                    using (var db = new AutoDataContext())
                    {
                        var query = from item in db.Reception
                                    join patient in db.Patient on item.patientid equals patient.id
                                    orderby item.dateNext
                                    where item.id == Param.id
                                    select new
                                    {
                                        id = item.id,
                                        patient = patient,
                                        fio = patient.lastName + " " + patient.firstName + " " + patient.middleName,
                                        cost = item.cost,
                                        dateNext = item.dateNext,
                                        completedWork = item.completedWork
                                    }
                                   ;

                        var arr = query.ToArray();

                        foreach (var record in arr)
                        {
                            RichEditCompletedWork.Document = new FlowDocument();
                            TextBoxPatient.Text = record.fio;
                            TextBoxCost.Text = record.cost.ToString();
                            DatePicker.SelectedDate = record.dateNext;
                            RichEditCompletedWork.AppendText(record.completedWork);

                            patient = record.patient;
                        }
                    }
                }
        }

    }
}
