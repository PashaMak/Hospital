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
    public class Doctors : INotifyPropertyChanged, INotifyPropertyChanging
    {
        //Primary key
        [Key]
        public int id { get; set; }

        //Column
        private string _firstName;
        [Column]
        public string firstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value) return;
                NotifyPropertyChanging("firstName");
                _firstName = value;
                NotifyPropertyChanged("firstName");
            }

        }

        private string _middleName;
        [Column]
        public string middleName
        {
            get { return _middleName; }
            set
            {
                if (_middleName == value) return;
                NotifyPropertyChanging("middleName");
                _middleName = value;
                NotifyPropertyChanged("middleName");
            }

        }

        private string _lastName;
        [Column]
        public string lastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value) return;
                NotifyPropertyChanging("lastName");
                _lastName = value;
                NotifyPropertyChanged("lastName");
            }

        }

        public double _hourRate { get; set; } //Hourly rate
        [Column]
        public double hourRate
        {
            get { return _hourRate; }
            set
            {
                if (_hourRate == value) return;
                NotifyPropertyChanging("hourRate");
                _hourRate = value;
                NotifyPropertyChanged("hourRate");
            }

        }


        /*
            Add new row in table Doctor
            Returnpost
            true if added sucsessfull
            false if don' added (have error message)
        */
        public static bool NewItem(string pFirstName, string pMiddleName, string pLastName, double pRate)
        {
            if (pFirstName.Trim() == "")
            {
                MessageBox.Show("Enter first name");
                return false;
            }

            if (pLastName.Trim() == "")
            {
                MessageBox.Show("Enter last name");
                return false;
            }

            using (var db = new AutoDataContext())
            {
                var items_query_employee = from item in db.Doctor
                                           where item.firstName == pFirstName.Trim()
                                            & item.middleName == pMiddleName.Trim()
                                            & item.lastName == pLastName.Trim()
                                           select item;

                if (items_query_employee.Count() != 0)
                {
                    MessageBox.Show("Doctor '" + pFirstName + pMiddleName + pLastName + "' already entered." + Environment.NewLine + "Saving cancelled!");
                    return false;
                }

                Doctors doc = new Doctors();
                doc.firstName = pFirstName;
                doc.middleName = pMiddleName;
                doc.lastName = pLastName;
                doc.hourRate = pRate;

                db.Doctor.Add(doc);
                db.SaveChanges();// add new employee

                return true;
            }
        }

        /*
          Update new row in table Doctor
          Return
           true if added sucsessfull
           false if don' added (have error message)
         */
        public static bool UpdateItem(int pid, string pFirstName, string pMiddleName, string pLastName, double pRate)
        {
            if (pFirstName.Trim() == "")
            {
                MessageBox.Show("Enter first name");
                return false;
            }

            if (pLastName.Trim() == "")
            {
                MessageBox.Show("Enter last name");
                return false;
            }

            using (var db = new AutoDataContext())
            {
                Doctors doc = db.Doctor.Find(pid);
                doc.firstName = pFirstName;
                doc.middleName = pMiddleName;
                doc.lastName = pLastName;
                doc.hourRate = pRate;

                db.SaveChanges();// update row

                return true;
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
