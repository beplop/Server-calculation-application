﻿#pragma checksum "..\..\CardControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D52D1D4E0C0352F4FEE95B21C31B6447D1B85DF1149E63B90BEFBDFFA2DB26F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfGameApp;


namespace WpfGameApp {
    
    
    /// <summary>
    /// CardControl
    /// </summary>
    public partial class CardControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid card;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle border;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property3;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property4;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property5;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock property6;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfGameApp;component/cardcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CardControl.xaml"
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
            
            #line 9 "..\..\CardControl.xaml"
            ((WpfGameApp.CardControl)(target)).DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.CardControl_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.card = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\CardControl.xaml"
            this.card.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grid_MouseDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\CardControl.xaml"
            this.card.MouseMove += new System.Windows.Input.MouseEventHandler(this.grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 13 "..\..\CardControl.xaml"
            this.card.DragEnter += new System.Windows.DragEventHandler(this.card_DragEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\CardControl.xaml"
            this.card.DragLeave += new System.Windows.DragEventHandler(this.card_DragLeave);
            
            #line default
            #line hidden
            
            #line 15 "..\..\CardControl.xaml"
            this.card.DragOver += new System.Windows.DragEventHandler(this.card_DragOver);
            
            #line default
            #line hidden
            return;
            case 3:
            this.border = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.property1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.property2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.property3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.property4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.property5 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.property6 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
