using mApp.Core;
using System;

namespace mApp.MVVM.ViewModel
{
    class MainViewModel : ObeservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand mShutterViewCommand { get; set; }
        public RelayCommand KillerViewCommand { get; set; }
        public RelayCommand NOterViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }
        public RelayCommand WifiPassViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public mShutterViewModel mShutterVM { get; set; }
        public KillerViewModel KillerVM { get; set; }
        public NoterViewModel NoterVM { get; set; }
        public AboutViewModel AboutVM { get; set; }
        public WifiPassViewModel WifiPassVM { get; set; }
       


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
            KillerVM = new KillerViewModel();
            NoterVM = new NoterViewModel();
            AboutVM = new AboutViewModel();
            WifiPassVM = new WifiPassViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            mShutterViewCommand = new RelayCommand(o =>
            {
                CurrentView = mShutterVM;
            });

            KillerViewCommand = new RelayCommand(o =>
            {
                CurrentView = KillerVM;
            });

            NOterViewCommand = new RelayCommand(o =>
            {
                CurrentView = NoterVM;
            });

            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVM;
            });

            WifiPassViewCommand = new RelayCommand(o =>
            {
                CurrentView = WifiPassVM;
            });
        }
    }
}
