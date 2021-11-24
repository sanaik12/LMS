Imports System.Data.OleDb
Public Class Form5
    Dim obj As New CONNECTION
    Dim str, str1, str2, str3, str4, str5, str6, str7 As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Dim a, b, c As String
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        str = "select * From ADD_BOOK where B_ID = '" & TextBox2.Text & "'"
        obj.cmd.CommandText = str
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox5.Text = obj.dr.Item(1)
            TextBox3.Text = obj.dr.Item(2)
            TextBox4.Text = obj.dr.Item(6)
            TextBox7.Text = obj.dr.Item(5)
            TextBox8.Text = obj.dr.Item(7)
            TextBox9.Text = obj.dr.Item(8)
            TextBox10.Text = obj.dr.Item(9)
            TextBox11.Text = obj.dr.Item(10)
        Else
            TextBox5.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub
    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        str1 = "select * from ADD_USER where ROLL_NO ='" & TextBox15.Text & "'"
        obj.cmd.CommandText = str1
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox13.Text = obj.dr.Item(1)
            TextBox14.Text = obj.dr.Item(3)
            TextBox16.Text = obj.dr.Item(4)
            TextBox17.Text = obj.dr.Item(5)
            TextBox18.Text = obj.dr.Item(6)
            TextBox19.Text = obj.dr.Item(7)
            TextBox20.Text = obj.dr.Item(8)
            TextBox12.Text = obj.dr.Item(9)
        Else
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""
            TextBox18.Text = ""
            TextBox19.Text = ""
            TextBox20.Text = ""
            TextBox12.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox11.Text = "ISSUED" Then
            MsgBox("BOOK IS NOT IN THE STOCK")
            TextBox2.Text = ""
        ElseIf TextBox19.Text = "STUDENT" And TextBox12.Text = 2 Then
            MsgBox("MAXIMUM BOOKS ISSUED")
            TextBox15.Text = ""
        ElseIf TextBox19.Text = "STAFF" And TextBox12.Text = 5 Then
            MsgBox("MAXIMUM BOOKS ISSUED")
            TextBox15.Text = ""
        Else
            str7 = "ISSUED"
            str3 = "insert into ISSUE_BOOK values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "','" & TextBox15.Text & "','" & TextBox13.Text & "','" & TextBox19.Text & "','" & TextBox6.Text & "','" & str7 & "')"
            obj.cmd.CommandText = str3
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteNonQuery()
            obj.cn.Close()
            str4 = "delete * from STOCK where B_ID='" & TextBox2.Text & "'"
            obj.cmd.CommandText = str4
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()
            c = CType(TextBox12.Text, Integer) + 1
            str5 = "update ADD_USER set BK_HLD=" & c & " where ROLL_NO='" & TextBox15.Text & "'"
            obj.cmd.CommandText = str5
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()
            str6 = "update ADD_BOOK set STATUS='" & str7 & "' where B_ID='" & TextBox2.Text & "'"
            obj.cmd.CommandText = str6
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()
            MsgBox("BOOK ISSUED SUCCESSFULLY")
            a = a + 1
            TextBox1.Text = "ISSUE-" + CType(a, String)
            TextBox2.Text = ""
            TextBox15.Text = ""
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        str2 = "select count(*) from ISSUE_BOOK"
        obj.cmd.CommandText = str2
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            a = obj.dr.Item(0) + 1
        Else
            a = 1
        End If
        obj.dr.Close()
        obj.cn.Close()
        TextBox1.Text = "ISSUE-" + CType(a, String)
        TextBox6.Text = DateAndTime.Today
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '//Form 5 Back Button code'
        Dim SecondForm As New Form2
        SecondForm.Show()
        Me.Hide()
    End Sub


End Class