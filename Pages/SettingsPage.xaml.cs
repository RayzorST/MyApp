using MyApp.Utils;
using MyApp.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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

namespace MyApp.Pages
{
    public partial class SettingsPage : Page
    {
        public static CustomColorsWindow customColorsWindow = new CustomColorsWindow();

        public SettingsPage()
        {
            InitializeComponent();
            AppInfoLabel.Content = "Версия приложения: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.StandartRed);
            ColorPalette.Save();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.StandartGreen);
            ColorPalette.Save();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.StandartBlue);
            ColorPalette.Save();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.Hacker);
            ColorPalette.Save();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.Anonimus);
            ColorPalette.Save();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ColorPalette.Set(MyApp.Resources.Colors.KillNet);
            ColorPalette.Save();
        }

        private void ButtonCustom_Click(object sender, RoutedEventArgs e)
        {
            if(customColorsWindow.IsVisible == false)
            {
                customColorsWindow.Top = MainWindow.mainWindow.Top + 235;
                customColorsWindow.Left = MainWindow.mainWindow.Left + 280;
                customColorsWindow.Show();
            }
        }
    }
}
