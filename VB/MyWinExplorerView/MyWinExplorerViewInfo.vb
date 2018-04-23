Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.WinExplorer.ViewInfo

Namespace MyXtraGrid
    Public Class MyWinExplorerViewInfo
        Inherits SkinWinExplorerViewInfo

        Public Sub New(ByVal view As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView)
            MyBase.New(view)

        End Sub
    End Class
End Namespace
