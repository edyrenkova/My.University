﻿#pragma checksum "..\..\News.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E79C651DDEB7FE931A97E5E07BC4090F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using My.University;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace My.University {
    
    
    /// <summary>
    /// News
    /// </summary>
    public partial class News : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal My.University.News w_News;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser wb_socnet;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle grad;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stp_icons;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView tv_univ;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem tv_item1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\News.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser wb_docs;
        
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
            System.Uri resourceLocater = new System.Uri("/My.University;component/news.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\News.xaml"
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
            this.w_News = ((My.University.News)(target));
            
            #line 8 "..\..\News.xaml"
            this.w_News.Loaded += new System.Windows.RoutedEventHandler(this.w_News_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\News.xaml"
            this.w_News.Closed += new System.EventHandler(this.w_News_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.wb_socnet = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 3:
            this.grad = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 13 "..\..\News.xaml"
            this.grad.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grad_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.stp_icons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.tv_univ = ((System.Windows.Controls.TreeView)(target));
            
            #line 25 "..\..\News.xaml"
            this.tv_univ.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.TreeView_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tv_item1 = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 8:
            this.wb_docs = ((System.Windows.Controls.WebBrowser)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

