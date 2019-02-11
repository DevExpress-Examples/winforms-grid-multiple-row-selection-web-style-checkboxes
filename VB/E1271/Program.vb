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

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace E1271
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace