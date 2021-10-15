using ModernDesign.Core;
using System;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObeservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand mShutterViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public mShutterViewModel mShutterVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            mShutterVM = new mShutterViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            mShutterViewCommand = new RelayCommand(o =>
            {
                CurrentView = mShutterVM;
            });
        }
    }
}
