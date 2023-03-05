using MyApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyApp.Windows
{
    public partial class CustomColorsWindow : Window
    {
        public CustomColorsWindow()
        {
            InitializeComponent();
        }

        private void Mouse_Drag(object sender, RoutedEventArgs e)
        {
            SettingsPage.customColorsWindow.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage.customColorsWindow.Hide();
        }
    }
}
