using System;
using System.Windows;
using System.Windows.Controls;


namespace mApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for mShutterView.xaml
    /// </summary>
    public partial class mShutterView : UserControl
    {
        bool zap = false;

        public mShutterView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int lol1 = Convert.ToInt32(slider1.Value);
            label1.Content = slider2.Value.ToString();
            System.Diagnostics.Process.Start("shutdown", "/s /t " + slider1.Value.ToString());
            int res = Convert.ToInt32(slider1.Value);
            zap = false;

            Countdown(lol1, TimeSpan.FromSeconds(1), cur => label3.Content = cur.ToString());

            MessageBoxResult result = MessageBox.Show("Tvoj PC sa vypne !", "Vypnutie", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Cancel)
            {
                System.Diagnostics.Process.Start("shutdown", "/a");
                zap = true;
                label3.Content = String.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
            zap = true;
            label3.Content = String.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int lol2 = Convert.ToInt32(slider2.Value);
            label1.Content = slider1.Value.ToString();
            System.Diagnostics.Process.Start("shutdown", "/r /t " + slider2.Value.ToString());
            zap = false;

            Countdown(lol2, TimeSpan.FromSeconds(1), cur => label3.Content = cur.ToString());

            MessageBoxResult result = MessageBox.Show("Tvoj PC sa reštartuje !", "Reštart", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Cancel)
            {
                System.Diagnostics.Process.Start("shutdown", "/a");
                zap = true;
                label3.Content = String.Empty;

            }
        }

        void Countdown(int count, TimeSpan interval, Action<int> ts)
        {
            var dt = new System.Windows.Threading.DispatcherTimer();
            dt.Interval = interval;
            dt.Tick += (_, a) =>
            {
                if (count-- == 0 || zap == true)
                {
                    dt.Stop();
                }

                else
                {
                    ts(count);
                }

            };
            ts(count);
            dt.Start();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label1.Content = slider1.Value.ToString();
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label2.Content = slider2.Value.ToString();
        }
    }
}
