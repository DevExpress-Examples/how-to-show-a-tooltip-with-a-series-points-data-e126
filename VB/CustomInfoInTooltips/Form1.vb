Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomInfoInTooltips
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub chartControl1_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs) Handles chartControl1.CustomDrawCrosshair
			For Each element As CrosshairElement In e.CrosshairElements
					Dim currentPoint As SeriesPoint = element.SeriesPoint

					If currentPoint.Tag.GetType() Is GetType(DataRowView) Then
						Dim rowView As DataRowView = CType(currentPoint.Tag, DataRowView)
						Dim s As String = "Unit price = " & rowView("UnitPrice").ToString() & Constants.vbCrLf & "Units in stock = " & rowView("UnitsInStock").ToString() & Constants.vbCrLf & "Quantity per unit = " & rowView("QuantityPerUnit").ToString()

						element.LabelElement.Text = s

					End If
			Next element
		End Sub
	End Class
End Namespace


