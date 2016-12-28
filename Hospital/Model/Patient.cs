using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class Patient : INotifyPropertyChanged
    {

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; NotifyPropertyChanged("id"); }
        }

        private string _fio;
        public string fio
        {
            get { return _fio; }
            set { _fio = value; NotifyPropertyChanged("fio"); }
        }

        private string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; NotifyPropertyChanged("gender"); }
        }

        private string _phoneNumber;
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; NotifyPropertyChanged("phoneNumber"); }
        }

        public Patient(int id, string fio, string gender, string phoneNumber)
        {
            this.id          = id;
            this.fio         = fio;
            this.gender      = gender;
            this.phoneNumber = phoneNumber;
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
