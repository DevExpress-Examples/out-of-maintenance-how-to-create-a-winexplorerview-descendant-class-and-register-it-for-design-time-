Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyXtraGrid
    Public Class MyWinExplorerViewInfoRegistrator
        Inherits WinExplorerViewInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyWinExplorerView"
            End Get
        End Property
        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyWinExplorerView()
        End Function
        Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
            Return New MyWinExplorerViewInfo(TryCast(view, MyWinExplorerView))
        End Function
        Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
            Return New MyWinExplorerViewHandler(TryCast(view, MyWinExplorerView))
        End Function
    End Class
End Namespace
