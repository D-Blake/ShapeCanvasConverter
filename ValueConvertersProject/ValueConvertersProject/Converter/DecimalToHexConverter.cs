using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConvertersProject.Converter
{
    public class DecimalToHex : IValueConverter, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _Decimal;
        private string _Hex;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(string))
                throw new Exception("The conversion target must be a string");
            
            _Hex = System.Convert.ToInt32(value).ToString("X");
            
            return _Hex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            _Decimal = Int32.Parse((string)value, System.Globalization.NumberStyles.HexNumber);
            return _Decimal;
        }

        #region Test

        //public int getDecimal()
        //{
        //    return _Decimal;
        //}
        //public void setToDecimal(string value)
        //{
        //        _Decimal = int.Parse(value, System.Globalization.NumberStyles.HexNumber);
        //        if (PropertyChanged != null)
        //            PropertyChanged(this, new PropertyChangedEventArgs("Decimal"));
        //}

        //public string getHex()
        //{
        //    return _Hex;
        //}
        //public void setToHex(int value)
        //{
        //    _Hex = value.ToString("X");
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs("Hex"));
        //}
        #endregion
    }
}
