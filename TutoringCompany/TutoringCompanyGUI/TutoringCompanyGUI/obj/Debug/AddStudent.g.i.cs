﻿#pragma checksum "..\..\AddStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66A852399D99F75DB93D301C5DCDBD69330EC9ABFBFDD069C5414937706333A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TutoringCompanyGUI;


namespace TutoringCompanyGUI {
    
    
    /// <summary>
    /// AddStudent
    /// </summary>
    public partial class AddStudent : TutoringCompanyGUI.WindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl TitleContent;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox studentName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox studentSurname;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox studentPhone;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox studentClient;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox studentTutor;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox studentClass;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox studentGender;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addStudent2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TutoringCompanyGUI;component/addstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddStudent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TitleContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.studentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.studentSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.studentPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.studentClient = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\AddStudent.xaml"
            this.studentClient.KeyUp += new System.Windows.Input.KeyEventHandler(this.studentClient_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.studentTutor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.studentClass = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.studentGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.addStudent2 = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\AddStudent.xaml"
            this.addStudent2.Click += new System.Windows.RoutedEventHandler(this.addStudent2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

