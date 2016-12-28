using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hospital.SQL
{
    public class Receptions : INotifyPropertyChanged, INotifyPropertyChanging
    {
        //Association
        [Association("patientRef", "patientid", "id", IsForeignKey = true)]
        public int patientid { get; set; } //references employee table

        //Reference
        //public Patients patient;
        //public Doctors doctor;

        #region Column

        //Primary key
        [Key]
        public int id { get; set; }

        //Column
        private string _providedService;
        [Column]
        public string providedService
        {
            get { return _providedService; }
            set
            {
                if (_providedService == value) return;
                NotifyPropertyChanging("providedService");
                _providedService = value;
                NotifyPropertyChanged("providedService");
            }

        }

        private double _cost;
        [Column]
        public double cost
        {
            get { return _cost; }
            set
            {
                if (_cost == value) return;
                NotifyPropertyChanging("cost");
                _cost = value;
                NotifyPropertyChanged("cost");
            }

        }

        private DateTime _dateNext;
        [Column]
        public DateTime dateNext
        {
            get { return _dateNext; }
            set
            {
                if (_dateNext == value) return;
                NotifyPropertyChanging("dateNext");
                _dateNext = value;
                NotifyPropertyChanged("dateNext");
            }

        }

        private string _completedWork;
        [Column]
         public string completedWork
        {
            get { return _completedWork; }
            set
            {
                if (_completedWork == value) return;
                NotifyPropertyChanging("completedWork");
                _completedWork = value;
                NotifyPropertyChanged("completedWork");
            }

        }

        #endregion

        public static Receptions GetItem(int pid)
        {
            Receptions reception = new Receptions();

            using (var db = new AutoDataContext())
            {
                reception = db.Reception.Find(pid);
            }

            return reception;
        }

        /*
        Add new row in table
        Returnpost
        true if added sucsessfull
        false if don' added (have error message)
        */
        public static bool NewItem(Patients patient, double cost, DateTime dateNext, string completedWork)
        {
            if (patient.id == 0)
            {
                MessageBox.Show("Patient not select");
                return false;
            }

            using (var db = new AutoDataContext())
            {
                Receptions reception = new Receptions();
                reception.patientid = patient.id;
                reception.cost = cost;
                reception.dateNext = dateNext;
                reception.completedWork = completedWork;

                db.Reception.Add(reception);
                db.SaveChanges();// add new

                return true;
            }
        }

        /*
          Update new row in table
          Return
           true if added sucsessfull
           false if don' added (have error message)
         */
        public static bool UpdateItem(int pid, Patients patient, double cost, DateTime dateNext, string completedWork)
        {
            if (patient.id == 0)
            {
                MessageBox.Show("Patient not select");
                return false;
            }

            using (var db = new AutoDataContext())
            {
                Receptions reception = db.Reception.Find(pid);
                reception.patientid = patient.id;
                reception.cost = cost;
                reception.dateNext = dateNext;
                reception.completedWork = completedWork;
                db.SaveChanges();// update row

                return true;
            }
        }

        public static void DeleteItem(int pid)
        {
            using (var db = new AutoDataContext())
            {
                Receptions reception = new Receptions();
                var items_query = from item in db.Reception
                                           where item.id == pid
                                           select item;

                if (items_query.Count() == 0)
                {
                    MessageBox.Show("Delete not completed (error: no correct id Reception table). Please contact service center.");
                    return;
                }

                foreach (var item in items_query)
                {
                    reception = item;
                }

                db.Reception.Remove(reception);
                try
                {
                    db.SaveChanges();// delete employee
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Delete reception complete with error: " + exc.Message);
                }
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the page that a data context property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        // Used to notify the data context that a data context property is about to change
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion
    }
}
