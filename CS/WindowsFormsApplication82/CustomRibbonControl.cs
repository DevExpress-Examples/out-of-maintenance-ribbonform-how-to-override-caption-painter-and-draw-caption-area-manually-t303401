using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication82 {
    public class CustomRibbonControl : RibbonControl {
        private Color _captionColor;

        public CustomRibbonControl() : base() {

        }
        protected override RibbonViewInfo CreateViewInfo() {
            return new CustomRibbonViewInfo(this);
        }
        public Color CaptionColor { get { return _captionColor; } set { _captionColor = value; } }
    }
}
