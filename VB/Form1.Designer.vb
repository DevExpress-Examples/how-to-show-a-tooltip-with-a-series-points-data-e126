Imports Microsoft.VisualBasic
Imports System
Namespace docShowSeriesPointTooltip
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim dataFilter1 As New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 5)
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.nwindDataSet = New docShowSeriesPointTooltip.nwindDataSet()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New docShowSeriesPointTooltip.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.DataAdapter = Me.productsTableAdapter
			Me.chartControl1.DataSource = Me.productsBindingSource
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.Label.Staggered = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			series1.DataFilters.AddRange(New DevExpress.XtraCharts.DataFilter() { dataFilter1})
			series1.PointOptionsTypeName = "PointOptions"
			series1.ArgumentDataMember = "ProductName"
			series1.ShowInLegend = False
			series1.ValueDataMembersSerializable = "UnitPrice"
			series1.Name = "Series 2"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.SeriesTemplate.PointOptionsTypeName = "PointOptions"
			Me.chartControl1.Size = New System.Drawing.Size(614, 358)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chartControl1_ObjectHotTracked);
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			Me.productsBindingSource.Position = 0
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(614, 358)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private productsTableAdapter As docShowSeriesPointTooltip.nwindDataSetTableAdapters.ProductsTableAdapter
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

