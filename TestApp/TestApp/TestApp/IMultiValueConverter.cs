using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MultiBindingExample
{
	public interface IMultiValueConverter
	{
		object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
	}
}
