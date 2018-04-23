using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Ribbon;

namespace RibbonSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class PageOffsetHelper {

        public static readonly DependencyProperty PageOffsetProperty = DependencyProperty.RegisterAttached("PageOffset", typeof(double), typeof(PageOffsetHelper), new FrameworkPropertyMetadata(50d));

        public static double GetPageOffset(DependencyObject target) {
            return (double)target.GetValue(PageOffsetProperty);
        }
        public static void SetPageOffset(DependencyObject target, PageOffsetHelper value) {
            target.SetValue(PageOffsetProperty, value);
        }
    }
}
