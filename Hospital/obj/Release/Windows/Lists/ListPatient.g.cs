﻿#pragma checksum "..\..\..\..\Windows\Lists\ListPatient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "08BD82FBEFA2B5AE02762AD3D62CB726"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hospital.ViewModel;
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


namespace Hospital.Windows {
    
    
    /// <summary>
    /// ListPatient
    /// </summary>
    public partial class ListPatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Windows\Lists\ListPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxView;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\Lists\ListPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\Lists\ListPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Windows\Lists\ListPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Windows\Lists\ListPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital;component/windows/lists/listpatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Lists\ListPatient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.ListBoxView = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Windows\Lists\ListPatient.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Windows\Lists\ListPatient.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Windows\Lists\ListPatient.xaml"
            this.ButtonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Windows\Lists\ListPatient.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

