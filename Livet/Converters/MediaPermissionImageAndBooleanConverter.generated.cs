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
    /// MediaPermissionImage列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class MediaPermissionImageAndBooleanConverter : IValueConverter
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
        private MediaPermissionImage _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのMediaPermissionImage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionImage ConvertWhenTrue
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
        private MediaPermissionImage _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのMediaPermissionImage列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public MediaPermissionImage ConvertWhenFalse
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
            if (!(value is MediaPermissionImage)) throw new ArgumentException();

            var enumValue = (MediaPermissionImage)value;

			switch(enumValue.ToString())
			{
				case "NoImage":
					if (_isConvertBackWhenNoImageSet)
					{
						return ConvertBackWhenNoImage;
					}
					break;
				case "SiteOfOriginImage":
					if (_isConvertBackWhenSiteOfOriginImageSet)
					{
						return ConvertBackWhenSiteOfOriginImage;
					}
					break;
				case "SafeImage":
					if (_isConvertBackWhenSafeImageSet)
					{
						return ConvertBackWhenSafeImage;
					}
					break;
				case "AllImage":
					if (_isConvertBackWhenAllImageSet)
					{
						return ConvertBackWhenAllImage;
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
        /// MediaPermissionImageの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNoImageSet;
        private bool _convertBackWhenNoImage;
		/// <summary>
        /// MediaPermissionImageの値がNoImageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoImage
        {
            get
            {
                return _convertBackWhenNoImage;
            }
            set
            {
                _convertBackWhenNoImage = value;
                _isConvertBackWhenNoImageSet = true;
            }
        }
        private bool _isConvertBackWhenSiteOfOriginImageSet;
        private bool _convertBackWhenSiteOfOriginImage;
		/// <summary>
        /// MediaPermissionImageの値がSiteOfOriginImageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSiteOfOriginImage
        {
            get
            {
                return _convertBackWhenSiteOfOriginImage;
            }
            set
            {
                _convertBackWhenSiteOfOriginImage = value;
                _isConvertBackWhenSiteOfOriginImageSet = true;
            }
        }
        private bool _isConvertBackWhenSafeImageSet;
        private bool _convertBackWhenSafeImage;
		/// <summary>
        /// MediaPermissionImageの値がSafeImageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSafeImage
        {
            get
            {
                return _convertBackWhenSafeImage;
            }
            set
            {
                _convertBackWhenSafeImage = value;
                _isConvertBackWhenSafeImageSet = true;
            }
        }
        private bool _isConvertBackWhenAllImageSet;
        private bool _convertBackWhenAllImage;
		/// <summary>
        /// MediaPermissionImageの値がAllImageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAllImage
        {
            get
            {
                return _convertBackWhenAllImage;
            }
            set
            {
                _convertBackWhenAllImage = value;
                _isConvertBackWhenAllImageSet = true;
            }
        }
    }
}