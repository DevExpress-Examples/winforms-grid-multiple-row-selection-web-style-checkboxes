using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Selection;

namespace E1271 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            new GridCheckMarksSelection(gridView1);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            this.colShipCountry.GroupIndex = 0;
            this.gridView1.ExpandAllGroups();
        }
    }
}