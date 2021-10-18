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
    /// Interaction logic for KillerView.xaml
    /// </summary>
    public partial class KillerView : UserControl
    {
        public KillerView()
        {
            InitializeComponent();
        }

        private void Spotify_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "spotify.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void chrome_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "chrome.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void VisualStudio_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "devenv.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void LeagueOfLegends_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "RiotClientServices.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void minecraft_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "RiotClientServices.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void Steam_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "steam.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "Discord.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void BattleNet_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "Battle.net.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }

        private void worldofwarcraft_Click(object sender, RoutedEventArgs e)
        {
            string kill;
            kill = "Wow.exe";
            System.Diagnostics.Process.Start("taskkill", "/f /im " + kill);
        }
    }
}
