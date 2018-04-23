using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication82 {
    public class CustomRibbonViewInfo : RibbonViewInfo {
        public CustomRibbonViewInfo(RibbonControl ribbon) : base(ribbon) {

        }
        protected override RibbonCaptionViewInfo CreateCaptionInfo() {
            return new CustomRibbonCaptionViewInfo(this);
        }
        CustomRibbonPageHeaderViewInfo _header;
        public override RibbonPageHeaderViewInfo Header {
            get {
                if (_header == null) {
                    _header = new CustomRibbonPageHeaderViewInfo(this);
                }
                return _header;
            }
        }
        public SkinElementInfo GetAppButtonContainerInfoEx(Rectangle bounds) {
            return GetAppButtonContainerInfo(bounds);
        }
        public class CustomRibbonPageHeaderViewInfo : RibbonPageHeaderViewInfo {
            public CustomRibbonPageHeaderViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) {

            }
        }
    }
}
