Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication82
	Public Class CustomRibbonControl
		Inherits RibbonControl

		Private _captionColor As Color

		Public Sub New()
			MyBase.New()

		End Sub
		Protected Overrides Function CreateViewInfo() As RibbonViewInfo
			Return New CustomRibbonViewInfo(Me)
		End Function
		Public Property CaptionColor() As Color
			Get
				Return _captionColor
			End Get
			Set(ByVal value As Color)
				_captionColor = value
			End Set
		End Property
	End Class
End Namespace
