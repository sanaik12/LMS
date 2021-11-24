Imports System.Data.OleDb
Public Class CONNECTION
    Public cn As New OleDbConnection("Provider= Microsoft.Jet.OleDb.4.0; Data Source= D:\LMS.mdb")
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public cn1 As New OleDbConnection("Provider= Microsoft.Jet.OleDb.4.0; Data Source= D:\LMS.mdb")
    Public cmd1 As New OleDbCommand
    Public dr1 As OleDbDataReader
End Class