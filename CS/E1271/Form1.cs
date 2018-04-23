// Developer Express Code Central Example:
// Multiple selection using checkbox (web style)
// 
// The following example shows how to implement multiple selection in the web style
// (via check boxes). The XtraGrid does not have this functionality built-in. The
// GridCheckMarksSelection class allows you to implement it. End-users can
// select/unselect rows, group rows or select/unselect all rows by clicking on the
// column header. Changing check box value does not start row editing. This example
// is based on the http://www.devexpress.com/scid=A371 article.
// 
// See
// Also:
// http://www.devexpress.com/scid=E990
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1271

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