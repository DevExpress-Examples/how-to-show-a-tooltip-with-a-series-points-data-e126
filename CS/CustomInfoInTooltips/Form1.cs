using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomInfoInTooltips {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void chartControl1_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            foreach (CrosshairElement element in e.CrosshairElements) {
                {
                    SeriesPoint currentPoint = element.SeriesPoint;

                    if (currentPoint.Tag.GetType() == typeof(DataRowView)) {
                        DataRowView rowView = (DataRowView)currentPoint.Tag;
                        string s = "Unit price = " + rowView["UnitPrice"].ToString() +
                            "\r\nUnits in stock = " + rowView["UnitsInStock"].ToString() +
                            "\r\nQuantity per unit = " + rowView["QuantityPerUnit"].ToString();

                        element.LabelElement.Text = s;

                    }
                }
            }
        }
    }
}


