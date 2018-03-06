using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MultiBindingExample;

namespace TestApp
{
	public class AndBooleanConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			var result = true;

			foreach(var val in values)
			{
				if(val == null)
				{
					//	Binding.DoNothing
					//	DependencyProperty.UnsetValue 
					return null;
				}

				if(val is IConvertible)
				{
					result = result && ((IConvertible)val).ToBoolean(CultureInfo.CurrentCulture);
				}
				else
				{
					throw new ArgumentException("Not boolean values not supported");
				}
			}

			return result;
		}
	}
}
