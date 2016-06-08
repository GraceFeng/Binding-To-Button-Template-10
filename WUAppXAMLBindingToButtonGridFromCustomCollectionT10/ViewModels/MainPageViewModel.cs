using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using WUAppXAMLBindingToButtonGridFromCustomCollectionT10.Models;

namespace WUAppXAMLBindingToButtonGridFromCustomCollectionT10.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<ButtonClass> ButtonCollection;

        public MainPageViewModel()
        {
            ButtonCollection = new ObservableCollection<ButtonClass>();
            for (int i = 0; i < 20; i++)
            {
                ButtonCollection.Add(new ButtonClass
                {
                    Label = "TButton " + i,
                    BChecked = true,
                    BEnabled = true,
                    ToggleBtnClickCommand = new DelegateCommand<string>(ToggleBtnClicked)
                });
            }
        }

        public void ToggleBtnClicked(string obj)
        {
            var buttonLable = obj;
        }
    }
}