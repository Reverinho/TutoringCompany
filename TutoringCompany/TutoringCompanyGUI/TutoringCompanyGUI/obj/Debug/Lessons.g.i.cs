﻿#pragma checksum "..\..\Lessons.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C02D9607BB8FF1ED26A6B57F498E56BCE12AA2BD168D081CF37AC12924C1A8F"
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
    /// Lessons
    /// </summary>
    public partial class Lessons : TutoringCompanyGUI.WindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\Lessons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl TitleContent;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Lessons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lessonsListBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Lessons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addLesson;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Lessons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteLesson;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Lessons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TutoringCompanyGUI;component/lessons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Lessons.xaml"
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
            this.lessonsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.addLesson = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Lessons.xaml"
            this.addLesson.Click += new System.Windows.RoutedEventHandler(this.addLesson_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.deleteLesson = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Lessons.xaml"
            this.deleteLesson.Click += new System.Windows.RoutedEventHandler(this.deleteLesson_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\Lessons.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 64 "..\..\Lessons.xaml"
            this.searchBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 64 "..\..\Lessons.xaml"
            this.searchBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

