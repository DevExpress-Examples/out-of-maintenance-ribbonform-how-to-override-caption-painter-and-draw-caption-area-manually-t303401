Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication82
	Public Class CustomRibbonCaptionPainter
		Inherits RibbonCaptionPainter

		Public Sub New()
			MyBase.New()

		End Sub
		Public Overrides Sub DrawObject(ByVal e As ObjectInfoArgs)
			Dim vi As RibbonViewInfo = CType(CType(e, RibbonDrawInfo).ViewInfo, RibbonViewInfo)
			If vi.Caption.Bounds.IsEmpty OrElse (Not e.Cache.IsNeedDrawRect(vi.Caption.Bounds)) Then
				Return
			End If

			'ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, vi.Caption.GetCaptionDrawInfo());
			Dim captionRectangle As Rectangle = vi.Caption.Bounds
			Dim br As Brush = If((TryCast(vi.Ribbon, CustomRibbonControl)).CaptionColor = Color.Empty, Brushes.White, New SolidBrush((TryCast(vi.Ribbon, CustomRibbonControl)).CaptionColor))
			'
			e.Cache.Paint.FillRectangle(e.Cache.Graphics, br, vi.Caption.Bounds)
			If vi.ShouldUseAppButtonContainerControlBkgnd AndAlso (TryCast(vi.Caption, CustomRibbonCaptionViewInfo)).CanGetFormButtonsBoundsEx Then
				Dim rect As Rectangle = (TryCast(vi.Caption, CustomRibbonCaptionViewInfo)).FormButtonBoundsEx
				If Not rect.IsEmpty Then
					ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, (TryCast(vi, CustomRibbonViewInfo)).GetAppButtonContainerInfoEx(Rectangle.Inflate(rect, 1, 1)))
				End If
			End If
			DrawCaption(e)
			DrawPageHeaderBackground(e, True)
			If (TryCast(vi.Caption, CustomRibbonCaptionViewInfo)).FormPainterEx IsNot Nothing Then
				TryCast(vi.Caption, CustomRibbonCaptionViewInfo).FormPainterEx.DrawIcon(e.Cache)
			End If
			If (TryCast(vi.Caption, CustomRibbonCaptionViewInfo)).FormPainterEx IsNot Nothing Then
				TryCast(vi.Caption, CustomRibbonCaptionViewInfo).FormPainterEx.DrawButtons(e.Cache, False)
			End If
			DrawPageCategories(TryCast(e, RibbonDrawInfo))
		End Sub
	End Class
End Namespace
