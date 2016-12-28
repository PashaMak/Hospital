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
    public class Patients : INotifyPropertyChanged, INotifyPropertyChanging
    {

        #region Column
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

        [Column]
        private string _gender;
        public string gender
        {
            get { return _gender; }
            set
            {
                if (_gender == value) return;
                NotifyPropertyChanging("gender");
                _gender = value;
                NotifyPropertyChanged("gender");
            }
        }

        [Column]
        private string _phoneNumber;
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber == value) return;
                NotifyPropertyChanging("phoneNumber");
                _phoneNumber = value;
                NotifyPropertyChanged("phoneNumber");
            }
        }
        
        #endregion

        public static Patients GetItem(int pid)
        {
            Patients patient = new Patients();

            using (var db = new AutoDataContext())
            {
                patient = db.Patient.Find(pid);
            }

            return patient;
        }

        /*
        Add new row in table
        Returnpost
        true if added sucsessfull
        false if don' added (have error message)
        */
        public static bool NewItem(string pFirstName, string pMiddleName, string pLastName, string pGender, string pPhoneNumber)
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
                var items_query_employee = from item in db.Patient
                                           where item.firstName == pFirstName.Trim()
                                            & item.middleName == pMiddleName.Trim()
                                            & item.lastName == pLastName.Trim()
                                           select item;

                if (items_query_employee.Count() != 0)
                {
                    MessageBox.Show("Patient '" + pFirstName + pMiddleName + pLastName + "' already entered." + Environment.NewLine + "Saving cancelled!");
                    return false;
                }

                Patients patient = new Patients();
                patient.firstName   = pFirstName;
                patient.middleName  = pMiddleName;
                patient.lastName    = pLastName;
                patient.gender      = pGender;
                patient.phoneNumber = pPhoneNumber;

                db.Patient.Add(patient);
                db.SaveChanges();// add new patient

                return true;
            }
        }

        /*
          Update new row in table
          Return
           true if added sucsessfull
           false if don' added (have error message)
         */
        public static bool UpdateItem(int pid, string pFirstName, string pMiddleName, string pLastName, string pGender, string pPhoneNumber)
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
                Patients patient = db.Patient.Find(pid);
                patient.firstName   = pFirstName;
                patient.middleName  = pMiddleName;
                patient.lastName    = pLastName;
                patient.gender      = pGender;
                patient.phoneNumber = pPhoneNumber;

                db.SaveChanges();// update row

                return true;
            }
        }

        public static void DeleteItem(int pid)
        {
            using (var db = new AutoDataContext())
            {
                Patients patient = new Patients();

                var items_query_employee = from item in db.Patient
                                           where item.id == pid
                                           select item;

                if (items_query_employee.Count() == 0)
                {
                    MessageBox.Show("Delete not completed (error: no correct id Employees table). Please contact service center.");
                    return;
                }

                foreach (var item in items_query_employee)
                {
                    patient = item;
                }

                db.Patient.Remove(patient);
                try
                {
                    db.SaveChanges();// delete employee
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Delete patient complete with error: " + exc.Message);
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
