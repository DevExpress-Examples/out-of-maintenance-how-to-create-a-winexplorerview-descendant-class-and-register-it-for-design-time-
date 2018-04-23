Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.WinExplorer

Namespace MyXtraGrid
    Public Class MyWinExplorerView
        Inherits WinExplorerView

        Public Sub New()

        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyWinExplorerView"
            End Get
        End Property
    End Class
End Namespace
