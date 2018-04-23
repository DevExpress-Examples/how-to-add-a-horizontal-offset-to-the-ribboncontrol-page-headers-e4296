Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Data
Imports System.Globalization
Imports DevExpress.Xpf.Ribbon
Imports System.Windows
Imports DevExpress.Xpf.Ribbon.Themes

Namespace RibbonSample
	Public Class Converter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			If value Is Nothing Then
				Return Nothing
			End If
			Dim rb As RibbonPage = CType(value, RibbonPage)
			Dim currentPageindex As Integer = rb.PageCategory.Pages.IndexOf(rb)
			Return If(currentPageindex = 0, New Thickness(PageOffsetHelper.GetPageOffset(rb.Ribbon), 0, 0, 0), CType(rb.FindResource(New RibbonPageThemeKeyExtension() With {.ResourceKey = RibbonPageThemeKeys.CaptionControlMargin}), Thickness))
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return value
		End Function
	End Class
End Namespace
