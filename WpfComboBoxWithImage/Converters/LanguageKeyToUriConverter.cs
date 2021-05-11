using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfComboBoxWithImage.Converters
{
    public class LanguageKeyToUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Uri($"/assets/flags/{value}.png", UriKind.Relative);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
