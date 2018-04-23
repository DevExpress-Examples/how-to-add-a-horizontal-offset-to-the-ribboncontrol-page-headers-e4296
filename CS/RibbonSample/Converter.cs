using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using DevExpress.Xpf.Ribbon;
using System.Windows;
using DevExpress.Xpf.Ribbon.Themes;

namespace RibbonSample {
    public class Converter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null) return null;
            RibbonPage rb = (RibbonPage)value;
            int currentPageindex = rb.PageCategory.Pages.IndexOf(rb);
            return currentPageindex == 0 ?  new Thickness(PageOffsetHelper.GetPageOffset(rb.Ribbon), 0, 0, 0) : (Thickness)rb.FindResource(new RibbonPageThemeKeyExtension() { ResourceKey = RibbonPageThemeKeys.CaptionControlMargin }) ;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture) {
            return value;
        }
    }
}
