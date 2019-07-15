using System;
using System.Windows.Forms;
namespace CustomInfoInTooltips {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            chartControl1.Series[0].CrosshairLabelPattern = "Unit price: {UnitPrice}\r\n" +
                                                            "Units in stock: {UnitsInStock}\r\n" +
                                                            "Quantity per unit: {QuantityPerUnit}";
        }
    }
}