using DevExpress.Skins.XtraForm;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication82 {
    public class CustomRibbonCaptionViewInfo : RibbonCaptionViewInfo {
        public CustomRibbonCaptionViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) {

        }
        protected override RibbonCaptionPainter CreateCaptionPainter() {
            return new CustomRibbonCaptionPainter();
        }
        public Rectangle FormButtonBoundsEx { get { return FormButtonsBounds; } }
        public RibbonFormPainter FormPainterEx { get { return FormPainter; } }
        public bool CanGetFormButtonsBoundsEx { get { return CanGetFormButtonsBounds; } }
    }
}
