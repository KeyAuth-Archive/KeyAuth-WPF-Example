using System;
using KeyAuth_WPF.Core;
using KeyAuth_WPF.View;

namespace KeyAuth_WPF.ViewModels
{
    class MainWindowViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand SubscriptionsViewCommand { get; set; }

        public RelayCommand ChangeThemeCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }

        public SubscriptionsViewModel SubscriptionsVM { get; set; }


        private object _currentView;


        public object CurrentView
        {
            get { return _currentView;  }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            HomeVM = new HomeViewModel();
            SubscriptionsVM = new SubscriptionsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            
            SubscriptionsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SubscriptionsVM;
            });
            
            ChangeThemeCommand = new RelayCommand(o =>
            {
                //Settings.Theme = "Light";
            });
        }
    }
}