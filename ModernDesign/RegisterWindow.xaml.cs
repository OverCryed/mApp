using System.Windows;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace mApp
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindows logWin = new LoginWindows();
            logWin.Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            MongoCRUD db = new MongoCRUD("mAppDataBase");


            INformations person = new INformations
            {
                email = name.Text,
                password = password.Password,
            };

            //-----------------------------------------------------------------------------
            //                          CHYBOVE HLASKY
            //-----------------------------------------------------------------------------

            if (password.Password != password2.Password)
            {
                password.BorderBrush = System.Windows.Media.Brushes.Red;
                password2.BorderBrush = System.Windows.Media.Brushes.Red;
                MessageBox.Show("Hesla sa nezhoduju !");
                AllMethods.WriteToConsole("passwords are not same.");

                return;
            }

            if (password.Password.Length < 5 || password2.Password.Length < 5)
            {
                password.BorderBrush = System.Windows.Media.Brushes.Red;
                password2.BorderBrush = System.Windows.Media.Brushes.Red;
                MessageBox.Show("minimalna dlzka hesla je 5 znakov !");
                AllMethods.WriteToConsole("minimum length for password is 5 char.");

                return;
            }

            if (name.Text == "")
            {
                name.BorderBrush = System.Windows.Media.Brushes.Red;
                MessageBox.Show("Zadaj meno !");
                AllMethods.WriteToConsole("wrong or empty name.");
                return;
            }


            try
            {
                db.InsertRecord("Users", person);

                this.Close();

                MessageBox.Show("Uspesne zaregistrovany!");
                AllMethods.WriteToConsole("Successfully registered.");
            }
            catch (Exception)
            {
                MessageBox.Show("Tento mail je uz pouzity!");
                AllMethods.WriteToConsole("This email andress is alreadt used.");
            }
        }

        private void redCross_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
