using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace hottrackchart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
        }

        private void chartControl1_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
            SeriesPoint point = e.AdditionalObject as SeriesPoint;           
            
            if (point != null) {
                DataRowView rowView = (DataRowView)point.Tag;

                string s = "Unit price = " + rowView["UnitPrice"].ToString() +
                    "\r\nUnits in stock = " + rowView["UnitsInStock"].ToString() +
                    "\r\nQuantity per unit = " + rowView["QuantityPerUnit"].ToString();              
                
                toolTipController1.ShowHint(s);
            }
            else
             toolTipController1.HideHint();
        }
    }
}
