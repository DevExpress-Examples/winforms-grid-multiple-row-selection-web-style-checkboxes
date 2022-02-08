Imports System.ComponentModel
Imports System.Drawing

Namespace E1271

    Public Class Record
        Implements INotifyPropertyChanged

        Public Sub New()
            Details = New BindingList(Of Detail)()
        End Sub

        Private idField As Integer

        Public Property ID As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                If idField <> value Then
                    idField = value
                    OnPropertyChanged("ID")
                End If
            End Set
        End Property

        Private parentIDField As Integer

        Public Property ParentID As Integer
            Get
                Return parentIDField
            End Get

            Set(ByVal value As Integer)
                If parentIDField <> value Then
                    parentIDField = value
                    OnPropertyChanged("ParentID")
                End If
            End Set
        End Property

        Private textField As String

        Public Property Text As String
            Get
                Return textField
            End Get

            Set(ByVal value As String)
                If Not Equals(textField, value) Then
                    textField = value
                    OnPropertyChanged("Text")
                End If
            End Set
        End Property

        Private infoField As String

        Public Property Info As String
            Get
                Return infoField
            End Get

            Set(ByVal value As String)
                If Not Equals(infoField, value) Then
                    infoField = value
                    OnPropertyChanged("Info")
                End If
            End Set
        End Property

        Private val As Decimal?

        Public Property Value As Decimal?
            Get
                Return val
            End Get

            Set(ByVal value As Decimal?)
                If val <> value Then
                    val = value
                    OnPropertyChanged("Value")
                End If
            End Set
        End Property

        Private dtField As Date

        Public Property Dt As Date
            Get
                Return dtField
            End Get

            Set(ByVal value As Date)
                If dtField <> value Then
                    dtField = value
                    OnPropertyChanged("Dt")
                End If
            End Set
        End Property

        Private stateField As Boolean

        Public Property State As Boolean
            Get
                Return stateField
            End Get

            Set(ByVal value As Boolean)
                If stateField <> value Then
                    stateField = value
                    OnPropertyChanged("State")
                End If
            End Set
        End Property

        Private imageField As Image

        Public Property Image As Image
            Get
                Return imageField
            End Get

            Set(ByVal value As Image)
                If imageField IsNot value Then
                    imageField = value
                    OnPropertyChanged("Image")
                End If
            End Set
        End Property

        Private detailsField As BindingList(Of Detail)

        Public Property Details As BindingList(Of Detail)
            Get
                Return detailsField
            End Get

            Set(ByVal value As BindingList(Of Detail))
                If detailsField IsNot value Then
                    detailsField = value
                    OnPropertyChanged("Details")
                End If
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return String.Format("ID = {0}", ID, Text)
        End Function

        Private detailField As Detail

        Public Property Detail As Detail
            Get
                Return detailField
            End Get

            Set(ByVal value As Detail)
                If detailField IsNot value Then
                    detailField = value
                    OnPropertyChanged("Detail")
                End If
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Public Class Detail
        Implements INotifyPropertyChanged

        Public Sub New()
        End Sub

        Private idField As Integer

        Public Property ID As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                If idField <> value Then
                    idField = value
                    OnPropertyChanged("ID")
                End If
            End Set
        End Property

        Private nameField As String

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                If Not Equals(nameField, value) Then
                    nameField = value
                    OnPropertyChanged("Name")
                End If
            End Set
        End Property

        Private infoField As String

        Public Property Info As String
            Get
                Return infoField
            End Get

            Set(ByVal value As String)
                If Not Equals(infoField, value) Then
                    infoField = value
                    OnPropertyChanged("Info")
                End If
            End Set
        End Property

        Private stateField As Boolean

        Public Property State As Boolean
            Get
                Return stateField
            End Get

            Set(ByVal value As Boolean)
                If stateField <> value Then
                    stateField = value
                    OnPropertyChanged("State")
                End If
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Public Class DataHelper

        Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
            Dim records As BindingList(Of Record) = New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With {.ParentID = If(i < 5, 1, 2), .ID = i, .Text = String.Format("Text {0}", i), .Info = String.Format("Info {0} Line 1" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 2" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 3" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 4" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 5" & Microsoft.VisualBasic.Constants.vbCrLf, i), .Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue), .State = i Mod 2 = 0, .Image = SystemIcons.Information.ToBitmap(), .Value = i * 0.00001D, .Detail = New Detail() With {.ID = i, .Name = String.Format("Text {0}", i), .State = i Mod 2 = 0}})
            Next

            Return records
        End Function

        Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer) As BindingList(Of Record)
            Dim records As BindingList(Of Record) = New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With {.ParentID = If(i < 5, 1, 2), .ID = i, .Text = String.Format("Text {0}", i), .Info = String.Format("Info {0} Line 1" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 2" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 3" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 4" & Microsoft.VisualBasic.Constants.vbCrLf & " Line 5" & Microsoft.VisualBasic.Constants.vbCrLf, i), .Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue), .State = i Mod 2 = 0, .Image = SystemIcons.Information.ToBitmap(), .Value = i * 0.00001D, .Detail = New Detail() With {.ID = i, .Name = String.Format("Text {0}", i), .State = i Mod 2 = 0}})
                Dim details As BindingList(Of Detail) = New BindingList(Of Detail)()
                For j As Integer = 0 To detailCount - 1
                    details.Add(New Detail() With {.ID = j, .Name = String.Format("Text {0}", j), .Info = String.Format("Info {0}", j)})
                Next

                records(i).Details = details
            Next

            Return records
        End Function
    End Class
End Namespace
