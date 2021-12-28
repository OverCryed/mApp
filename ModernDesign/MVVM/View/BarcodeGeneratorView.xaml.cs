using Microsoft.Win32;
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
using ZXing;

namespace mApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for BarcodeGeneratorView.xaml
    /// </summary>
    public partial class BarcodeGeneratorView : UserControl
    {
        public BarcodeGeneratorView()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {

            System.Drawing.Image img = null;
            BitmapImage bimg = new BitmapImage();
            using (var ms = new MemoryStream())
            {
                try
                {
                    //System.Drawing.Image img = null;
                    //BitmapImage bimg = new BitmapImage();
                    //using (var ms = new MemoryStream())
                    {
                        BarcodeWriter writer;
                        writer = new ZXing.BarcodeWriter() { Format = BarcodeFormat.CODE_93 };
                        writer.Options.Height = 80;
                        writer.Options.Width = 280;
                        writer.Options.PureBarcode = true;
                        img = writer.Write(this.text.Text);
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ms.Position = 0;
                        bimg.BeginInit();
                        bimg.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                        bimg.CacheOption = BitmapCacheOption.OnLoad;
                        bimg.UriSource = null;
                        bimg.StreamSource = ms;
                        bimg.EndInit();
                        this.imgBox.Source = bimg;// return File(ms.ToArray(), "image/jpeg");  
                                                  // this.tbkbarcodecontent.Text = this.txtbarcodecontent.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (imgBox == null)
                return;

          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.Filter = "JPEG|*.jpeg|PNG|*.png|Text file(*.txt)|*txt|c# file (*.cs)|*.cs";
          if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, text.Text);
            }
        }
    }
}
