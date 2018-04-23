using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.WinExplorer;

namespace MyXtraGrid
{
    public class MyWinExplorerView : WinExplorerView
    {
        public MyWinExplorerView()
        {
            
        }
        protected override string ViewName { get { return "MyWinExplorerView"; } }
    }
}
