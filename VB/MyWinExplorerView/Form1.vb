Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace MyXtraGrid
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim image As Image = My.Resources.img
            For i As Integer = 0 To 9
                dataTable1.Rows.Add("Item" & i, image)
            Next i
        End Sub
    End Class
End Namespace
