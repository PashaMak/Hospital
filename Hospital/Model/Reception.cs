using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class Reception : INotifyPropertyChanged
    {

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; NotifyPropertyChanged("id"); }
        }

        private string _patient;
        public string patient
        {
            get { return _patient; }
            set { _patient = value; NotifyPropertyChanged("patient"); }
        }

        private double _cost;
        public double cost
        {
            get { return _cost; }
            set { _cost = value; NotifyPropertyChanged("cost"); }
        }

        private string _completedWork;
        public string completedWork
        {
            get { return _completedWork; }
            set { _completedWork = value; NotifyPropertyChanged("completedWork"); }
        }

        private DateTime _dateNext;
        public DateTime dateNext
        {
            get { return _dateNext; }
            set { _dateNext = value; NotifyPropertyChanged("dateNext"); }
        }

        public Reception(int id, string patient, double cost, DateTime dateNext, string completedWork)
        {
            this.id             = id;
            this.patient        = patient;
            this.cost           = cost;
            this.dateNext       = dateNext;
            this.completedWork  = completedWork;
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
