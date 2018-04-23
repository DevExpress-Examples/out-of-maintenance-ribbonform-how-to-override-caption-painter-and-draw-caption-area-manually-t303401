Imports DevExpress.Skins.XtraForm
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication82
    Public Class CustomRibbonCaptionViewInfo
        Inherits RibbonCaptionViewInfo

        Public Sub New(ByVal viewInfo As RibbonViewInfo)
            MyBase.New(viewInfo)

        End Sub
        Protected Overrides Function CreateCaptionPainter() As ObjectPainter
            Return New CustomRibbonCaptionPainter()
        End Function
        Public ReadOnly Property FormButtonBoundsEx() As Rectangle
            Get
                Return FormButtonsBounds
            End Get
        End Property
        Public ReadOnly Property FormPainterEx() As RibbonFormPainter
            Get
                Return FormPainter
            End Get
        End Property
        Public ReadOnly Property CanGetFormButtonsBoundsEx() As Boolean
            Get
                Return CanGetFormButtonsBounds
            End Get
        End Property
    End Class
End Namespace
