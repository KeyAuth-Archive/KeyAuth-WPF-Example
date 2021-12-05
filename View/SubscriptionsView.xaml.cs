using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeyAuth_WPF.Core;
using KeyAuth_WPF.Windows;

namespace KeyAuth_WPF.View
{
    /// <summary>
    /// Interaction logic for Subscriptions.xaml
    /// </summary>
    public partial class SubscriptionsView : UserControl
    {
        public SubscriptionsView()
        {
            InitializeComponent();
        }

        private void SelectedCheatGroupBox_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.TextBlock3.Text = LoginWindow.KeyAuthApp.user_data.subscriptions[0].expiry;
        }

        private void CheatListView_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            var item = (ListViewItem)ListView.SelectedItem;
            var content = (string)item.Content;

            item.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 255));

            Settings.SelectedCheat = content;

            GroupBox2.Visibility = Visibility.Visible;
            TextBlock2.Text = Settings.SelectedCheat;
        }

        private void SubscriptionsView_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Settings.SelectedCheat == "NOITEM")
            {
                GroupBox2.Visibility = Visibility.Hidden;
            }


            if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "1")
            {
                Arma3.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "2")
            {
                ApexLegends.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "3")
            {
                HuntShowdown.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "4")
            {
                DayZ.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "5")
            {
                R6S.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "6")
            {
                EFT.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription == "7")
            {
                Rust.IsEnabled = true;
            }
            else if (LoginWindow.KeyAuthApp.user_data.subscriptions[0].subscription  == "8")
            {
                GTA5.IsEnabled = true;
            }
        }
    }
}
