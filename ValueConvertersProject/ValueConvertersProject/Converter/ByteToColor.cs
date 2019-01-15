using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConvertersProject.Converter
{
    public class ByteToColorConverter : IMultiValueConverter
    {
        SolidColorBrush brush;
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte a;
            byte r;
            byte g;
            byte b;
            byte.TryParse((string)values[0], out a);
            byte.TryParse((string)values[1], out r);
            byte.TryParse((string)values[2], out g);
            byte.TryParse((string)values[3], out b);

            brush = new SolidColorBrush(new Color { A = a, R = r, G = g, B = b});
            return brush;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
