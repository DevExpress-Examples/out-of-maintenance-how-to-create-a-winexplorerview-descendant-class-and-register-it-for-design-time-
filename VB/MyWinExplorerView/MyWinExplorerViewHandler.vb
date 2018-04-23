Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.WinExplorer.Handler

Namespace MyXtraGrid
    Public Class MyWinExplorerViewHandler
        Inherits WinExplorerViewHandler

        Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Base.BaseView)
            MyBase.New(view)

        End Sub
    End Class
End Namespace
