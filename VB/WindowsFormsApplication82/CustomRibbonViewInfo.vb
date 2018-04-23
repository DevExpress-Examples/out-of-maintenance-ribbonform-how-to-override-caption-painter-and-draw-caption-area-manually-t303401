Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication82
    Public Class CustomRibbonViewInfo
        Inherits RibbonViewInfo

        Public Sub New(ByVal ribbon As RibbonControl)
            MyBase.New(ribbon)

        End Sub
        Protected Overrides Function CreateCaptionInfo() As RibbonCaptionViewInfo
            Return New CustomRibbonCaptionViewInfo(Me)
        End Function
        Private _header As CustomRibbonPageHeaderViewInfo
        Public Overrides ReadOnly Property Header() As RibbonPageHeaderViewInfo
            Get
                If _header Is Nothing Then
                    _header = New CustomRibbonPageHeaderViewInfo(Me)
                End If
                Return _header
            End Get
        End Property
        Public Function GetAppButtonContainerInfoEx(ByVal bounds As Rectangle) As SkinElementInfo
            Return GetAppButtonContainerInfo(bounds)
        End Function
        Public Class CustomRibbonPageHeaderViewInfo
            Inherits RibbonPageHeaderViewInfo

            Public Sub New(ByVal viewInfo As RibbonViewInfo)
                MyBase.New(viewInfo)

            End Sub
        End Class
    End Class
End Namespace
