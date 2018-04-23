' Developer Express Code Central Example:
' Multiple selection using checkbox (web style)
' 
' The following example shows how to implement multiple selection in the web style
' (via check boxes). The XtraGrid does not have this functionality built-in. The
' GridCheckMarksSelection class allows you to implement it. End-users can
' select/unselect rows, group rows or select/unselect all rows by clicking on the
' column header. Changing check box value does not start row editing. This example
' is based on the http://www.devexpress.com/scid=A371 article.
' 
' See
' Also:
' http://www.devexpress.com/scid=E990
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1271


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