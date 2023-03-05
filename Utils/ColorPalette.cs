using MyApp.Properties;
using System.Windows;
using System.Windows.Media;

namespace MyApp.Utils
{
    public class ColorPalette
    {
        public static void Set()
        {
            string[] MasColors = Settings.Default["Colors"].ToString().Split('/');

            Application.Current.Resources["Color1"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[0]);
            Application.Current.Resources["Color2"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[1]);
            Application.Current.Resources["ColorText"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[2]);

            Application.Current.Resources["ColorGradient1"] = (Color)ColorConverter.ConvertFromString(MasColors[3]);
            Application.Current.Resources["ColorGradient2"] = (Color)ColorConverter.ConvertFromString(MasColors[4]);
            Application.Current.Resources["ColorGradient3"] = (Color)ColorConverter.ConvertFromString(MasColors[5]);
        }
        public static void Set(string Colors)
        {
            string[] MasColors = Colors.Split('/');

            Application.Current.Resources["Color1"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[0]);
            Application.Current.Resources["Color2"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[1]);
            Application.Current.Resources["ColorText"] = (SolidColorBrush)new BrushConverter().ConvertFromString(MasColors[2]);

            Application.Current.Resources["ColorGradient1"] = (Color)ColorConverter.ConvertFromString(MasColors[3]);
            Application.Current.Resources["ColorGradient2"] = (Color)ColorConverter.ConvertFromString(MasColors[4]);
            Application.Current.Resources["ColorGradient3"] = (Color)ColorConverter.ConvertFromString(MasColors[5]);
        }

        public static void Save()
        {
            Settings.Default["Colors"] = $"{Application.Current.Resources["Color1"]}/" +
                                         $"{Application.Current.Resources["Color2"]}/" +
                                         $"{Application.Current.Resources["ColorText"]}/" +
                                         $"{Application.Current.Resources["ColorGradient1"]}/" +
                                         $"{Application.Current.Resources["ColorGradient2"]}/" +
                                         $"{Application.Current.Resources["ColorGradient3"]}";

            Settings.Default.Save();
        }
    }
}
