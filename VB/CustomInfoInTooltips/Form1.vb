Imports System
Imports System.Windows.Forms
Namespace CustomInfoInTooltips
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			chartControl1.Series(0).CrosshairLabelPattern = "Unit price: {UnitPrice}" & vbCrLf &
															"Units in stock: {UnitsInStock}" & vbCrLf &
															"Quantity per unit: {QuantityPerUnit}"
		End Sub
	End Class
End Namespace