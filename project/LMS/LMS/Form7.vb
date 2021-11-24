Imports System.Data.OleDb
Public Class Form7
    Dim obj As New CONNECTION
    Dim a, b, c, d As String
    Dim str, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12 As String

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        str12 = "select BK_HLD from ADD_USER where ROLL_NO  = '" & TextBox5.Text & "' "
        obj.cmd1.CommandText = str12
        obj.cmd1.Connection = obj.cn1
        obj.cn1.Open()
        obj.dr1 = obj.cmd1.ExecuteReader()
        If obj.dr1.Read = True Then
            TextBox11.Text = obj.dr1.Item(0)
        Else
            TextBox11.Text = "0"
        End If
        obj.cn1.Close()
        obj.dr1.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox10.Text = "RETURNED" Then
            MsgBox("CANNOT RETURN THE BOOK AS IT IS NOT ISSUED")
        Else
            str7 = "RETURNED"
            str6 = "IN STOCK"
            str9 = "select * from ADD_BOOK where B_ID='" & TextBox3.Text & "'"
            obj.cmd.CommandText = str9
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                str10 = obj.dr.Item(2)
                str11 = obj.dr.Item(4)
                b = obj.dr.Item(5)
            Else
                str10 = ""
                str11 = ""
                b = 0
            End If
            obj.dr.Close()
            obj.cn.Close()

            str2 = "insert into RETURN_BOOK VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            obj.cmd.CommandText = str2
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteNonQuery()
            obj.cn.Close()
            str3 = "insert into STOCK values('" & TextBox4.Text & "','" & TextBox6.Text & "','" & str10 & "'," & b & ",'" & str11 & "')"
            obj.cmd.CommandText = str3
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteNonQuery()
            obj.cn.Close()
            str4 = "update ADD_BOOK set STATUS= '" & str6 & "' where B_ID='" & TextBox4.Text & "'"
            obj.cmd.CommandText = str4
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()
            str5 = "update ISSUE_BOOK set STATUS='" & str7 & "' where ISS_ID='" & TextBox3.Text & "'"
            obj.cmd.CommandText = str5
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()
            c = CType(TextBox11.Text, Integer) - 1
            str8 = "update ADD_USER set BK_HLD=" & c & " where ROLL_NO='" & TextBox5.Text & "'"
            obj.cmd.CommandText = str8
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.cmd.ExecuteReader()
            obj.cn.Close()

            MsgBox("RETURN BOOK SUCCESSFULLY")
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        str1 = "select * from ISSUE_BOOK where ISS_ID ='" & TextBox3.Text & "'"
        obj.cmd.CommandText = str1
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox4.Text = obj.dr.Item(1)
            TextBox5.Text = obj.dr.Item(3)
            TextBox6.Text = obj.dr.Item(2)
            TextBox7.Text = obj.dr.Item(4)
            TextBox8.Text = obj.dr.Item(5)
            TextBox9.Text = obj.dr.Item(6)
            TextBox10.Text = obj.dr.Item(7)
        Else
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Secondform As New Form2
        Secondform.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        str = "select count(*) from RETURN_BOOK"
        obj.cmd.CommandText = str
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
        TextBox1.Text = "RETURN-" + CType(a, String)
        TextBox2.Text = DateAndTime.Today
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class