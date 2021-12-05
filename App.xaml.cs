using System;
using System.Runtime.Remoting.Contexts;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Navigation;
using MaterialDesignColors;

namespace KeyAuth_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public PrimaryColor PrimaryColor { get; set; }
        public SecondaryColor SecondaryColor { get; set; }
        public BaseTheme BaseTheme { get; set; }

        public static App GetRecord()
        {
            var app = new App();
            {
                app.PrimaryColor = PrimaryColor.Pink;
                app.SecondaryColor = SecondaryColor.DeepPurple;
                app.BaseTheme = BaseTheme.Dark;
            };
            return app;
        }

        public App()
        {
            InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.StartupUri = new Uri("Windows/LoginWindow.xaml", UriKind.Relative);
        }

        private void App_OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            //this.BundledThemeTest.BaseTheme = BaseTheme.Dark;
            //this.BundledThemeTest.BaseTheme = BaseTheme.Dark;
        }
    }
}
