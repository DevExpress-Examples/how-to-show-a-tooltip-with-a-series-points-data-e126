Imports System
Imports System.Windows.Forms

Namespace CustomInfoInTooltips

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(nwindDataSet.Products)
            chartControl1.Series(0).CrosshairLabelPattern = "Unit price: {UnitPrice}" & Microsoft.VisualBasic.Constants.vbCrLf & "Units in stock: {UnitsInStock}" & Microsoft.VisualBasic.Constants.vbCrLf & "Quantity per unit: {QuantityPerUnit}"
        End Sub
    End Class
End Namespace
