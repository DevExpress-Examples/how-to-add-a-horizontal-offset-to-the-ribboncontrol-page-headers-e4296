Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Ribbon

Namespace RibbonSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class PageOffsetHelper

		Public Shared ReadOnly PageOffsetProperty As DependencyProperty = DependencyProperty.RegisterAttached("PageOffset", GetType(Double), GetType(PageOffsetHelper), New FrameworkPropertyMetadata(50R))

		Public Shared Function GetPageOffset(ByVal target As DependencyObject) As Double
			Return CDbl(target.GetValue(PageOffsetProperty))
		End Function
		Public Shared Sub SetPageOffset(ByVal target As DependencyObject, ByVal value As PageOffsetHelper)
			target.SetValue(PageOffsetProperty, value)
		End Sub
	End Class
End Namespace
