Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Selection

Namespace E1271
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim TempGridCheckMarksSelection As GridCheckMarksSelection = New GridCheckMarksSelection(gridView1)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
			Me.colShipCountry.GroupIndex = 0
			Me.gridView1.ExpandAllGroups()
		End Sub
	End Class
End Namespace