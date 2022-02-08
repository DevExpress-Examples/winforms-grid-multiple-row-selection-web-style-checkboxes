Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace E1271
    Public Class Record
        Implements INotifyPropertyChanged

        Public Sub New()
            Details = New BindingList(Of Detail)()
        End Sub

        Private id_Renamed As Integer
        Public Property ID() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                If id_Renamed <> value Then
                    id_Renamed = value
                    OnPropertyChanged("ID")
                End If
            End Set
        End Property

        Private parentID_Renamed As Integer
        Public Property ParentID() As Integer
            Get
                Return parentID_Renamed
            End Get
            Set(ByVal value As Integer)
                If parentID_Renamed <> value Then
                    parentID_Renamed = value
                    OnPropertyChanged("ParentID")
                End If
            End Set
        End Property

        Private text_Renamed As String
        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                If text_Renamed <> value Then
                    text_Renamed = value
                    OnPropertyChanged("Text")
                End If
            End Set
        End Property

        Private info_Renamed As String
        Public Property Info() As String
            Get
                Return info_Renamed
            End Get
            Set(ByVal value As String)
                If info_Renamed <> value Then
                    info_Renamed = value
                    OnPropertyChanged("Info")
                End If
            End Set
        End Property
        Private val? As Decimal
        Public Property Value() As Decimal?
            Get
                Return val
            End Get
            Set(ByVal value? As Decimal)
                If Not val.Equals(value) Then
                    val = value
                    OnPropertyChanged("Value")
                End If
            End Set
        End Property

        Private dt_Renamed As Date
        Public Property Dt() As Date
            Get
                Return dt_Renamed
            End Get
            Set(ByVal value As Date)
                If dt_Renamed <> value Then
                    dt_Renamed = value
                    OnPropertyChanged("Dt")
                End If
            End Set
        End Property

        Private state_Renamed As Boolean
        Public Property State() As Boolean
            Get
                Return state_Renamed
            End Get
            Set(ByVal value As Boolean)
                If state_Renamed <> value Then
                    state_Renamed = value
                    OnPropertyChanged("State")
                End If
            End Set
        End Property

        Private image_Renamed As Image
        Public Property Image() As Image
            Get
                Return image_Renamed
            End Get
            Set(ByVal value As Image)
                If image_Renamed IsNot value Then
                    image_Renamed = value
                    OnPropertyChanged("Image")
                End If
            End Set
        End Property

        Private details_Renamed As BindingList(Of Detail)
        Public Property Details() As BindingList(Of Detail)
            Get
                Return details_Renamed
            End Get
            Set(ByVal value As BindingList(Of Detail))
                If details_Renamed IsNot value Then
                    details_Renamed = value
                    OnPropertyChanged("Details")
                End If
            End Set
        End Property
        Public Overrides Function ToString() As String
            Return String.Format("ID = {0}", ID, Text)
        End Function

        Private detail_Renamed As Detail
        Public Property Detail() As Detail
            Get
                Return detail_Renamed
            End Get
            Set(ByVal value As Detail)
                If detail_Renamed IsNot value Then
                    detail_Renamed = value
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

        Private id_Renamed As Integer
        Public Property ID() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                If id_Renamed <> value Then
                    id_Renamed = value
                    OnPropertyChanged("ID")
                End If
            End Set
        End Property

        Private name_Renamed As String
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                If name_Renamed <> value Then
                    name_Renamed = value
                    OnPropertyChanged("Name")
                End If
            End Set
        End Property

        Private info_Renamed As String
        Public Property Info() As String
            Get
                Return info_Renamed
            End Get
            Set(ByVal value As String)
                If info_Renamed <> value Then
                    info_Renamed = value
                    OnPropertyChanged("Info")
                End If
            End Set
        End Property

        Private state_Renamed As Boolean
        Public Property State() As Boolean
            Get
                Return state_Renamed
            End Get
            Set(ByVal value As Boolean)
                If state_Renamed <> value Then
                    state_Renamed = value
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
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ParentID = If(i < 5, 1, 2), _
                    .ID = i, _
                    .Text = String.Format("Text {0}", i), _
                    .Info = String.Format("Info {0} Line 1" & ControlChars.CrLf & " Line 2" & ControlChars.CrLf & " Line 3" & ControlChars.CrLf & " Line 4" & ControlChars.CrLf & " Line 5" & ControlChars.CrLf, i), _
                    .Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue), _
                    .State = i Mod 2 = 0, _
                    .Image = SystemIcons.Information.ToBitmap(), _
                    .Value = (i * 0.00001D), _
                    .Detail = New Detail() With { _
                        .ID = i, _
                        .Name = String.Format("Text {0}", i), _
                        .State = i Mod 2 = 0 _
                    } _
                })
            Next i
            Return records
        End Function
        Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ParentID = If(i < 5, 1, 2), _
                    .ID = i, _
                    .Text = String.Format("Text {0}", i), _
                    .Info = String.Format("Info {0} Line 1" & ControlChars.CrLf & " Line 2" & ControlChars.CrLf & " Line 3" & ControlChars.CrLf & " Line 4" & ControlChars.CrLf & " Line 5" & ControlChars.CrLf, i), _
                    .Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue), _
                    .State = i Mod 2 = 0, _
                    .Image = SystemIcons.Information.ToBitmap(), _
                    .Value = (i * 0.00001D), _
                    .Detail = New Detail() With { _
                        .ID = i, _
                        .Name = String.Format("Text {0}", i), _
                        .State = i Mod 2 = 0 _
                    } _
                })
                Dim details As New BindingList(Of Detail)()
                For j As Integer = 0 To detailCount - 1
                    details.Add(New Detail() With { _
                        .ID = j, _
                        .Name = String.Format("Text {0}", j), _
                        .Info = String.Format("Info {0}", j) _
                    })
                Next j
                records(i).Details = details
            Next i

            Return records
        End Function
    End Class
End Namespace
