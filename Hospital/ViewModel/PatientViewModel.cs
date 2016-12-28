using Hospital.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Hospital.SQL;

namespace Hospital.ViewModel
{
    public class PatientViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Patient> listPatient;

        public PatientViewModel()
        { 
            listPatient = new ObservableCollection<Patient>(); 
        }

        public void Load()
        {
            listPatient.Clear();

            using (var db = new AutoDataContext())//load values into listbox
            {
                var query = from item in db.Patient
                            orderby item.lastName, item.firstName, item.middleName
                            select new
                            {
                                id = item.id,
                                firstName = item.firstName,
                                lastName = item.lastName,
                                middleName = item.middleName,
                                gender = item.gender,
                                phoneNumber = item.phoneNumber
                            }
                           ;

                var arr = query.ToArray();

                foreach (var record in arr)
                {
                    Patient lst = new Patient(record.id
                                                , record.lastName + " " + record.firstName + " " + record.middleName
                                                , record.gender
                                                , record.phoneNumber
                                                );
                    listPatient.Add(lst);
                }
            }
        }

        public void Delete(int id)
        {
            Patients.DeleteItem(id);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
