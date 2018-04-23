using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication82 {
    public class CustomRibbonCaptionPainter : RibbonCaptionPainter {
        public CustomRibbonCaptionPainter() : base() {

        }
        public override void DrawObject(ObjectInfoArgs e) {
            RibbonViewInfo vi = (RibbonViewInfo)((RibbonDrawInfo)e).ViewInfo;
            if (vi.Caption.Bounds.IsEmpty || !e.Cache.IsNeedDrawRect(vi.Caption.Bounds)) return;

            //ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, vi.Caption.GetCaptionDrawInfo());
            Rectangle captionRectangle = vi.Caption.Bounds;
            Brush br = (vi.Ribbon as CustomRibbonControl).CaptionColor == Color.Empty ? Brushes.White : new SolidBrush((vi.Ribbon as CustomRibbonControl).CaptionColor);
            //
            e.Cache.Paint.FillRectangle(e.Cache.Graphics, br, vi.Caption.Bounds);
            if (vi.ShouldUseAppButtonContainerControlBkgnd && (vi.Caption as CustomRibbonCaptionViewInfo).CanGetFormButtonsBoundsEx) {
                Rectangle rect = (vi.Caption as CustomRibbonCaptionViewInfo).FormButtonBoundsEx;
                if (!rect.IsEmpty)
                    ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, (vi as CustomRibbonViewInfo).GetAppButtonContainerInfoEx(Rectangle.Inflate(rect, 1, 1)));
            }
            DrawCaption(e);
            DrawPageHeaderBackground(e, true);
            if ((vi.Caption as CustomRibbonCaptionViewInfo).FormPainterEx != null) (vi.Caption as CustomRibbonCaptionViewInfo).FormPainterEx.DrawIcon(e.Cache);
            if ((vi.Caption as CustomRibbonCaptionViewInfo).FormPainterEx != null) (vi.Caption as CustomRibbonCaptionViewInfo).FormPainterEx.DrawButtons(e.Cache, false);
            DrawPageCategories(e as RibbonDrawInfo);
        }
    }
}
