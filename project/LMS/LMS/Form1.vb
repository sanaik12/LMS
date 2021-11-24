Imports System.Data.OleDb
Public Class Form1
#Region "windows form desiginer code"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
#Region "Declarition"
    Dim obj As New CONNECTION
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "select PASS from USER_LOGIN where USERID ='" & TextBox1.Text & "'"
        obj.cmd.CommandText = str
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            If TextBox2.Text = obj.dr.Item(0) Then
                '//NEW FORM 1 TO FORM 2 SHOW CODE'
                Dim f2 As New Form2
                f2.Show()
                Me.Visible = False
            Else
                MsgBox("Invalid Password")
                TextBox2.Text = ""
            End If
        Else
            MsgBox("User Does Not Exists")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
