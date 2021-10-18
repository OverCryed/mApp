using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for NoterView.xaml
    /// </summary>
    public partial class NoterView : UserControl
    {
        public NoterView()
        {
            InitializeComponent();
        }

    //    private void Save_Click(object sender, RoutedEventArgs e)
    //    {

    //        if (ChatTextBox.Text == "" || nazov.Text == "")
    //        {
    //            MessageBox.Show("Zadaj názov alebo text");
    //            Save.IsEnabled = false;
    //            Save.IsEnabled = true;
    //        }
    //        else
    //        {
    //            TextWriter txt = new StreamWriter(@"D:\AlliOne\Texty\ " + nazov.Text + ".txt");
    //            txt.Write(ChatTextBox.Text);
    //            txt.Close();

    //            MessageBox.Show("Tvoj záznam bol úspešne uložený");

    //            ChatTextBox.Text = "";
    //            nazov.Text = "";
    //        }
    //    }

    //    private void nacitaj_Click(object sender, RoutedEventArgs e)
    //    {
    //        System.Diagnostics.Process.Start(@"D:\AlliOne\Texty");
    //    }
    }
}
