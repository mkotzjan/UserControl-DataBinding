using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControl_DataBinding.Model
{
    class MainModel : INotifyPropertyChanged
    {
        string first;
        string last;

        public string firstname
        {
            get
            {
                return first;
            }

            set
            {
                if (value != first)
                {
                    first = value;
                    RaisePropertyChanged("firstname");
                }
            }
        }

        public string lastname
        {
            get
            {
                return last;
            }

            set
            {
                if (value != last)
                {
                    last = value;
                    RaisePropertyChanged("lastname");
                }
            }
        }

        public void RaisePropertyChanged(string prop)
        {
            if (this.PropertyChanged != null) { this.PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
