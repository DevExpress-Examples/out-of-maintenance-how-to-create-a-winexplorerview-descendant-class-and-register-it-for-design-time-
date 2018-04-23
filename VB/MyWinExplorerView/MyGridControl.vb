Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace MyXtraGrid
    <ToolboxItem(True)> _
    Public Class MyGridControl
        Inherits GridControl

        Protected Overrides Function CreateDefaultView() As BaseView
            Return CreateView("MyWinExplorerView")
        End Function
        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyWinExplorerViewInfoRegistrator())
        End Sub
    End Class
End Namespace
