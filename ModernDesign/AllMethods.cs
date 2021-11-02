using mApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace mApp
{
    public class AllMethods
    {
        static bool startWork = true;

        public static string txtBox_consoleText { get; set; }
        public static void WriteToConsole(string text)
        {
            if (startWork == true)
            {
                txtBox_consoleText = txtBox_consoleText + text + "\n";
                OnPropertyChanged(txtBox_consoleText);
            }

            //MongoCRUD db = new MongoCRUD("mAppDataBase");    //toto som mal pre databazu...

            //consoleClass console = new consoleClass
            //{
            //    text = text
            //};

            //try
            //{
            //    db.InsertRecord("Console", console);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("I dont know");
            //}
        }
        public static event PropertyChangedEventHandler PropertyChanged;
        private static void OnPropertyChanged([CallerMemberName] string x = null)
        {
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(x));
        }
    }
}



        //    public static string txtBox_consoleText { get; set; }

        //    static int callsWriteToConsole;
        //   static bool startWork = true;
        //    public static void WriteToConsole(string text)
        //    {
        //        if (startWork == true)
        //        {
        //            callsWriteToConsole++;
        //            if (callsWriteToConsole >= 500)
        //            {
        //                txtBox_consoleText = "";
        //                callsWriteToConsole = 0;
        //            }
        //            txtBox_consoleText = txtBox_consoleText + text + "\n";
        //            OnPropertyChanged(txtBox_consoleText);
        //        }
        //    }

        //    public static event PropertyChangedEventHandler PropertyChanged;
        //    private static  void OnPropertyChanged([CallerMemberName] string x = null)
        //    {
        //        PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(x));
        //    }

