using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;

namespace WUAppXAMLBindingToButtonGridFromCustomCollectionT10.Models
{
    public class ButtonClass : BindableBase
    {
        public string Label { get; set; }
        public bool BEnabled { get; set; }

        private bool _bChecked;

        public bool BChecked
        {
            get { return _bChecked; }
            set
            {
                _bChecked = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ToggleBtnClickCommand { get; set; }
    }
}