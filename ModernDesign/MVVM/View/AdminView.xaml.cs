using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
        }

        //private void Text1_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    Text1.Text = "";
        //}

        private void Text1Button_Click(object sender, RoutedEventArgs e)
        {
            MongoCRUD db = new MongoCRUD("mAppDataBase");


            TextModel text = new TextModel
            {
                nadpi1 = Text1.Text
            };

            INformations info = new INformations
            {
                email = "matus",
            };

            try
            {
               // var oneRec = db.LoadRecordById<INformations>("Users", new string("m"));   nejde to !!!
                db.InsertRecord("Texts", text);

                MessageBox.Show("Zapisane");
                AllMethods.WriteToConsole("Successfully writted.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                AllMethods.WriteToConsole("There is problem with wrtiting nadpis number one.");
            }
        }
    
    }
}
