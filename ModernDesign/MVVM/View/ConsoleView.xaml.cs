using mApp.Core;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace mApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for ConsoleView.xaml
    /// </summary>
    public partial class ConsoleView : UserControl
    {

        //int callsWriteToConsole;
        //bool startWork = true;
        public ConsoleView()
        {
            InitializeComponent();
            this.DataContext = new AllMethods();
        }

      //  private void Button_Click(object sender, RoutedEventArgs e)    //toto som mal pre databazu
      //  {
            //MongoCRUD db = new MongoCRUD("mAppDataBase");

            //var recs = db.LoadRecords<consoleClass>("Console");

            //txtBox_console.ItemsSource = recs;
       // }

        //private void txtBox_console_TextChanged(object sender, TextChangedEventArgs e)  //toto len automaticky skroluje dole..
        //{
        //    txtBox_console.ScrollToEnd();
        //}



        //public void WriteToConsole(string text)
        //{
        //    if (startWork == true)
        //    {
        //        callsWriteToConsole++;
        //        //this.Dispatcher.Invoke(() =>
        //        // {
        //        if (callsWriteToConsole >= 500)
        //        {
        //            txtBox_console.Text = "";
        //            callsWriteToConsole = 0;
        //        }
        //        txtBox_console.Text = txtBox_console.Text + text + "\n";
        //        OnPropertyChanged("txtBox_console");  //"txtBox_consoleText"
        //        //});
        //    }

        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //private void OnPropertyChanged([CallerMemberName] string x = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        //}
    }
}
