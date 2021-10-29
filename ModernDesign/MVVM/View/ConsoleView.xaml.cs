using mApp.Core;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using System.Windows.Controls;


namespace mApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for ConsoleView.xaml
    /// </summary>
    public partial class ConsoleView : UserControl
    {

        int callsWriteToConsole;
        bool startWork = true;
        public ConsoleView()
        {
            InitializeComponent();
            WriteToConsole("Hello wordl!!!");
        }

        private void WriteToConsole(string text)
        {
            if (startWork == true)
            {
                callsWriteToConsole++;
                //this.Dispatcher.Invoke(() =>
                // {
                if (callsWriteToConsole >= 500)
                {
                    txtBox_console.Text = "";
                    callsWriteToConsole = 0;
                }
                txtBox_console.Text = txtBox_console.Text + text + "\n";
             //   OnPropertyChanged();  //"txtBox_consoleText"
                //});
            }
        }
    }
}
