﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 10.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace LivetEnumAndBooleanConverterGenerator
{
    using System;
    
    
    #line 1 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class EnumToBooleanConverter : EnumToBooleanConverterBase
    {
        public virtual string TransformText()
        {
            
            #line 2 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"

// You can remove full path from generated code in Visual Studio.
// 1. Show [Find and Replace] dialog (generally ctrl+shift+H).
// 2. Enter '{\#line [1-9]+} ".+\\{[^\\]+\.tt}"' to finding string text box (without single quots).
// 3. Enter '\1 "\2"' to replacement string text box (without single quots).
// 4. Specify search condition as 'Regular expressions'
// 5. Click [Replace All]

            
            #line default
            #line hidden
            this.Write(@"//このコードはT4 Templateによって自動生成されています。

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
    /// ");
            
            #line 49 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("列挙体とbool値の相互変換を行うIValueConverterです。\r\n    /// </summary>\r\n    public class ");
            
            #line 51 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@"AndBooleanConverter : IValueConverter
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
        private ");
            
            #line 77 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" _convertWhenTrue;\r\n\t\t/// <summary>\r\n        /// ソース値がTrueの際にどの");
            
            #line 79 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("列挙体メンバーに変換するかを指定、または取得します。\r\n        /// </summary>\r\n        public ");
            
            #line 81 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@" ConvertWhenTrue
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
        private ");
            
            #line 95 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" _convertWhenFalse;\r\n\t\t/// <summary>\r\n        /// ソース値がFalseの際にどの");
            
            #line 97 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("列挙体メンバーに変換するかを指定、または取得します。\r\n        /// </summary>\r\n        public ");
            
            #line 99 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@" ConvertWhenFalse
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
            if (!(value is ");
            
            #line 115 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(")) throw new ArgumentException();\r\n\r\n            var enumValue = (");
            
            #line 117 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(")value;\r\n\r\n\t\t\tswitch(enumValue.ToString())\r\n\t\t\t{\r\n");
            
            #line 121 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
 
foreach(var memberName in EnumMemberNames)
{

            
            #line default
            #line hidden
            this.Write("\t\t\t\tcase \"");
            
            #line 125 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("\":\r\n\t\t\t\t\tif (_isConvertBackWhen");
            
            #line 126 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("Set)\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\treturn ConvertBackWhen");
            
            #line 128 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t\t}\r\n\t\t\t\t\tbreak;\r\n");
            
            #line 131 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"

}

            
            #line default
            #line hidden
            this.Write(@"				default:
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
        /// ");
            
            #line 149 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@"の値をbool値に変換する際のデフォルト値を指定、または取得します。
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

");
            
            #line 164 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
 
foreach(var memberName in EnumMemberNames)
{

            
            #line default
            #line hidden
            this.Write("        private bool _isConvertBackWhen");
            
            #line 168 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("Set;\r\n        private bool _convertBackWhen");
            
            #line 169 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t/// <summary>\r\n        /// ");
            
            #line 171 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("の値が");
            
            #line 171 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("の際True/Falseいずれに変換するのかを指定、または取得します。<br/>\r\n        /// この値が設定されておらず、ConvertBackDef" +
                    "aultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。\r\n        /// </s" +
                    "ummary>\r\n        public bool ConvertBackWhen");
            
            #line 174 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get\r\n            {\r\n                return _convertBackW" +
                    "hen");
            
            #line 178 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(";\r\n            }\r\n            set\r\n            {\r\n                _convertBackWhe" +
                    "n");
            
            #line 182 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n                _isConvertBackWhen");
            
            #line 183 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write("Set = true;\r\n            }\r\n        }\r\n");
            
            #line 186 "C:\ImportantProjects\LivetProject\Livet\LivetEnumAndBooleanConverterGenerator\EnumToBooleanConverter.tt"

}

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public class EnumToBooleanConverterBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
