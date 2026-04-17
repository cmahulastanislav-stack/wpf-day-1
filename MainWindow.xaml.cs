using System;
using System.Windows;
using Wpf_day_2.views;

namespace Wpf_day_2
{
    public partial class MainWindow : Window
    {
        private bool isDark = false;

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListPage());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingsPage());
        }

        private void SwitchTheme_Click(object sender, RoutedEventArgs e)
        {
            var dict = new ResourceDictionary();

            if (isDark)
                dict.Source = new Uri("Resources/LightTheme.xaml", UriKind.Relative);
            else
                dict.Source = new Uri("Resources/DarkTheme.xaml", UriKind.Relative);

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary { Source = new Uri("Resources/Styles.xaml", UriKind.Relative) });

            isDark = !isDark;
        }
    }
}