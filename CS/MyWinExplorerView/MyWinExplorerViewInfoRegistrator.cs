using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyWinExplorerViewInfoRegistrator : WinExplorerViewInfoRegistrator
    {
        public override string ViewName { get { return "MyWinExplorerView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyWinExplorerView(); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyWinExplorerViewInfo(view as MyWinExplorerView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyWinExplorerViewHandler(view as MyWinExplorerView); }
    }
}
