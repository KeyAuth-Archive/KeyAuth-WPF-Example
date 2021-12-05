
using MaterialDesignThemes.Wpf;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace KeyAuth_WPF.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            TextBlockWelcome.Text += LoginWindow.KeyAuthApp.user_data.username;
        }

        private void CaptionButtons_Click(object sender, RoutedEventArgs e)
        {
          
            Button button = (Button)sender;
            if (button.Content is PackIcon pI)
            { 
                switch (pI.Kind)
                {
                    case PackIconKind.WindowClose:
                        BeginStoryboard sb = this.FindResource("CloseAnim") as BeginStoryboard;
                        sb.Storyboard.Begin();
                        Close();
                        break;
                    case PackIconKind.WindowMinimize:
                        WindowState = WindowState.Minimized;
                        break;
                }
            }
        } 
        

        private bool ClosingAnimationFinished;

        private void FinishedClosingAnimation(object sender, EventArgs e)
        {
            ClosingAnimationFinished = true;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ClosingAnimationFinished)
            {
                BeginStoryboard sb = this.FindResource("CloseAnim") as BeginStoryboard;
                sb.Storyboard.Begin();
                e.Cancel = true;
            }
        }

        private void RadioButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.RadioButton.Foreground = new SolidColorBrush(Color.FromRgb(150, 150, 150));
        }   

        private void RadioButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            this.RadioButton.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
        
        private void RadioButton1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            this.RadioButton1.Foreground = new SolidColorBrush(Color.FromRgb(150, 150, 150));
        }

        private void RadioButton1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            this.RadioButton1.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}