using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Threading;

namespace mApp 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new User();
            //AdminButton.Visibility = Visibility.Hidden;

            //  ConsoleAllocator.ShowConsoleWindow();     //toto len zapne konzolu, to mozem urobyt aj v settings...

            //((MainWindow)System.Windows.Application.Current.MainWindow).UpdateLayout();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            Application.Current.Dispatcher.BeginInvoke(           // toto by malo fungovat ako "Refresh"  appky 
            DispatcherPriority.Background,
            new Action(() =>
            {
                if (Users.Text == "admin")                        //toto je len na to ze ak som prihlaseny pod "admin" tak mam zobrazene okna adt..
                {
                    AdminButton.Visibility = Visibility.Visible;
                }
                else
                {
                    AdminButton.Visibility = Visibility.Hidden;
                }
            }));
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void redCross_MouseDown(object sender, MouseButtonEventArgs e)   //toto mam vypnutie appky (okna), po stlaceni na X
        {
            this.Close();
        }

        private void minimize_MouseDown(object sender, MouseButtonEventArgs e) //Minimalizovanie okna, po stlaceni na -
        {
            this.WindowState = WindowState.Minimized;
        }

        //----------------------------------------------------------------------------------
        //                  Drag and Drop App Window    ez pz :D
        //----------------------------------------------------------------------------------

        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void user_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindows loginWin = new LoginWindows();
            loginWin.Show();
            this.Close();
        }

        private void logout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindows loginWin = new LoginWindows();
            loginWin.Show();
            this.Close();
        }




        //----------------------------------------------------------------------------------
        //                           ? Admin Mod ?
        //----------------------------------------------------------------------------------

        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        ////    if (e.Key != Key.K)
        ////    {
        ////        e.Handled = true;
        ////        AdminButton.Visibility = Visibility.Hidden;
        ////    }
        ////    else
        ////    {
        ////        e.Handled = true;
        ////        AdminButton.Visibility = Visibility.Visible;
        ////    }
        //}
    }

}
