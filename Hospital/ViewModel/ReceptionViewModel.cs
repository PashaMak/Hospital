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
    public class ReceptionViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Reception> listReception;

        public ReceptionViewModel()
        {
            listReception = new ObservableCollection<Reception>();
        }

        public void Load()
        {
            listReception.Clear();

            using (var db = new AutoDataContext())//load values into listbox
            {
                var query = from item in db.Reception
                            join patient in db.Patient on item.patientid equals patient.id
                            orderby item.dateNext
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
                    Reception lst = new Reception(record.id
                                                , record.fio
                                                , record.cost
                                                , record.dateNext
                                                , record.completedWork
                                                );
                    listReception.Add(lst);
                }
            }
        }

        public void Delete(int id)
        {
            Receptions.DeleteItem(id);
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
