Namespace MyXtraGrid
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.myGridControl1 = New MyXtraGrid.MyGridControl()
            Me.myWinExplorerView1 = New MyXtraGrid.MyWinExplorerView()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myWinExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.Location = New System.Drawing.Point(13, 13)
            Me.myGridControl1.MainView = Me.myWinExplorerView1
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(400, 200)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.DataSource = Me.bindingSource1
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myWinExplorerView1})
            ' 
            ' myWinExplorerView1
            ' 
            Me.myWinExplorerView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
            Me.myWinExplorerView1.ColumnSet.MediumImageColumn = Me.gridColumn2
            Me.myWinExplorerView1.ColumnSet.TextColumn = Me.gridColumn1
            Me.myWinExplorerView1.Name = "myWinExplorerView1"
            Me.myWinExplorerView1.GridControl = Me.myGridControl1
            Me.myWinExplorerView1.Name = "myWinExplorerView1"
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
            Me.dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Column1"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Column2"
            Me.dataColumn2.DataType = GetType(System.Drawing.Image)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Column1"
            Me.gridColumn1.FieldName = "Column1"
            Me.gridColumn1.Name = "colColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Column2"
            Me.gridColumn2.FieldName = "Column2"
            Me.gridColumn2.Name = "colColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Table1"
            Me.bindingSource1.DataSource = Me.dataSet1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(468, 261)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myWinExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myGridControl1 As MyGridControl
        Private myWinExplorerView1 As MyWinExplorerView
        Private dataSet1 As System.Data.DataSet
        Private dataTable1 As System.Data.DataTable
        Private dataColumn1 As System.Data.DataColumn
        Private dataColumn2 As System.Data.DataColumn
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private bindingSource1 As System.Windows.Forms.BindingSource
    End Class
End Namespace

