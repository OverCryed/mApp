using MongoDB.Bson;
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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            MongoCRUD db = new MongoCRUD("mAppDataBase");

            var _texts = db.LoadRecords<TextModel>("Texts");

            foreach (var text in _texts)
            {
                Nadpis.Text = text.nadpi1;
            }

            //Nadpis.Text = _texts.ToString() ;
        }
    }
}
