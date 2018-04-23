using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace MyXtraGrid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyWinExplorerView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyWinExplorerViewInfoRegistrator());
        }
    }
}
