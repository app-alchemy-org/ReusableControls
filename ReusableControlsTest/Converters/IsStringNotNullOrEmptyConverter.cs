using System.Globalization;

namespace ReusableControlsTest.Converters
{
    internal class IsStringNotNullOrEmptyConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not string stringValue) return false;
            if (string.IsNullOrEmpty(stringValue)) return false;
            return true;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
