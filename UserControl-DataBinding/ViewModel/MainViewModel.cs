using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControl_DataBinding.Model;

namespace UserControl_DataBinding.ViewModel
{
    class MainViewModel
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

        }
    }
}
