using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControl_DataBinding.Model;

namespace UserControl_DataBinding.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private List<MainModel> model;

        public List<MainModel> modelList
        {
            get
            {
                return model;
            }

            set
            {
                if (value != model)
                {
                    model = value;
                    RaisePropertyChanged("modelList");
                }
            }
        }
        public MainViewModel()
        {
            List<MainModel> model = new List<MainModel>();
            model.Add(new MainModel { firstname = "Michael", lastname = "Mustermann" });

        }

        public void RaisePropertyChanged(string prop)
        {
            if (this.PropertyChanged != null) { this.PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
