using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Hospital.Converter
{
    public class DateToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime date = (DateTime)value;
                var shortDate = date.ToShortDateString();

                return shortDate;
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parametr, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
