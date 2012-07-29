﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// DataGridHeadersVisibility列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class DataGridHeadersVisibilityAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private DataGridHeadersVisibility _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのDataGridHeadersVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridHeadersVisibility ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private DataGridHeadersVisibility _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのDataGridHeadersVisibility列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public DataGridHeadersVisibility ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is DataGridHeadersVisibility)) throw new ArgumentException();

            var enumValue = (DataGridHeadersVisibility)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Column":
					if (_isConvertBackWhenColumnSet)
					{
						return ConvertBackWhenColumn;
					}
					break;
				case "Row":
					if (_isConvertBackWhenRowSet)
					{
						return ConvertBackWhenRow;
					}
					break;
				case "All":
					if (_isConvertBackWhenAllSet)
					{
						return ConvertBackWhenAll;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// DataGridHeadersVisibilityの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// DataGridHeadersVisibilityの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenColumnSet;
        private bool _convertBackWhenColumn;
		/// <summary>
        /// DataGridHeadersVisibilityの値がColumnの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenColumn
        {
            get
            {
                return _convertBackWhenColumn;
            }
            set
            {
                _convertBackWhenColumn = value;
                _isConvertBackWhenColumnSet = true;
            }
        }
        private bool _isConvertBackWhenRowSet;
        private bool _convertBackWhenRow;
		/// <summary>
        /// DataGridHeadersVisibilityの値がRowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRow
        {
            get
            {
                return _convertBackWhenRow;
            }
            set
            {
                _convertBackWhenRow = value;
                _isConvertBackWhenRowSet = true;
            }
        }
        private bool _isConvertBackWhenAllSet;
        private bool _convertBackWhenAll;
		/// <summary>
        /// DataGridHeadersVisibilityの値がAllの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAll
        {
            get
            {
                return _convertBackWhenAll;
            }
            set
            {
                _convertBackWhenAll = value;
                _isConvertBackWhenAllSet = true;
            }
        }
    }
}