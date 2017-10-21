﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace DQ2
{
	class ItemConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			uint id = (uint)value;
			return Info.Instance().Item(id)?.Name;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
