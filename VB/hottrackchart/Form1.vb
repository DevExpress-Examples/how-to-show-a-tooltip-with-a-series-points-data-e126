Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace hottrackchart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
		End Sub

		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
			Dim point As SeriesPoint = TryCast(e.AdditionalObject, SeriesPoint)

			If point IsNot Nothing Then
				Dim rowView As DataRowView = CType(point.Tag, DataRowView)

				Dim s As String = "Unit price = " & rowView("UnitPrice").ToString() & Constants.vbCrLf & "Units in stock = " & rowView("UnitsInStock").ToString() & Constants.vbCrLf & "Quantity per unit = " & rowView("QuantityPerUnit").ToString()

				toolTipController1.ShowHint(s)
			Else
			 toolTipController1.HideHint()
			End If
		End Sub
	End Class
End Namespace
