﻿using System;
using System.Windows;
using System.Windows.Data;

namespace NodeWithImageDemo
{
    /// <summary>
    ///  Represents the visibility multi converter.
    /// </summary>
    public class BoolToVisibilityMultiConverter : IMultiValueConverter
    {
        /// <summary>
        /// Convert method to change the boolean property to visibility.
        /// </summary>
        /// <param name="values">Value to be convert</param>
        /// <param name="targetType">Target type in which value to be convert</param>
        /// <param name="parameter">Parameter which is to be passed to the object</param>
        /// <param name="culture">Culture in which visibility occcurs</param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "{DependencyProperty.UnsetValue}")
            {
                if ((bool)values[0] || (bool)values[1])
                    return Visibility.Visible;
            }
            return Visibility.Hidden;
        }
        /// <summary>
        /// Convert back method.
        /// </summary>
        /// <param name="value">Value to be convert back</param>
        /// <param name="targetTypes">Target type in which value to be convert back</param>
        /// <param name="parameter">Parameter which is to be passed to the object</param>
        /// <param name="culture">Culture in which visibility occcurs</param>
        /// <returns></returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
