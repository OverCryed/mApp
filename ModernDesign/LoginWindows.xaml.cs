﻿using System;
using System.Windows;


namespace mApp
{
    /// <summary>
    /// Interaction logic for LoginWindows.xaml
    /// </summary>
    public partial class LoginWindows : Window
    {
        public LoginWindows()
        {
            InitializeComponent();
        }

        //private void Register_Click(object sender, RoutedEventArgs e)
        //{
        //    RegisterWindow regWin = new RegisterWindow();
        //    regWin.Show();
        //    this.Close();
        //}

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            MongoCRUD db = new MongoCRUD("mAppDataBase");

            var recs = db.LoadRecords<INformations>("Users");

            foreach (var rec in recs)    //prehladavam zaznamy v DB
            {
                if (rec.email == name.Text && rec.password == password.Password) //ak to v kolonke meno  sa zhoduje so zaznamom v DB tak + heslo tak to prejde
                {
                    name.BorderBrush = System.Windows.Media.Brushes.Black;
                    password.BorderBrush = System.Windows.Media.Brushes.Black;
                    MessageBox.Show("Parada, prihlaseny !");
                    AllMethods.WriteToConsole("Successfully loged id.");
                    this.Close();
                }
                else if (rec.email != name.Text && rec.password != password.Password)
                {
                    name.BorderBrush = System.Windows.Media.Brushes.Red;
                    password.BorderBrush = System.Windows.Media.Brushes.Red;
                    AllMethods.WriteToConsole("You cant log in due to wrong username or password");
                }
            }
        }

        private void redCross_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void register_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RegisterWindow regWin = new RegisterWindow();
            regWin.Show();
            this.Close();
        }
    }
}
