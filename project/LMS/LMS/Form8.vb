Imports System.Data.OleDb
Public Class Form8
    Dim obj As New CONNECTION
    Dim a, b, c, d As String
    Dim str, str1, str2, str3, str4, str5 As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = False
        ComboBox1.Visible = False
        TextBox3.Visible = True
        TextBox3.ReadOnly = True
        DateTimePicker1.Visible = False
        TextBox4.Visible = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        ComboBox2.Visible = False
        TextBox7.Visible = True
        TextBox8.ReadOnly = True
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox11.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox12.Visible = False
        ComboBox3.Visible = True
        TextBox14.ReadOnly = False
        TextBox14.Visible = False
        DateTimePicker2.Visible = True
        TextBox15.ReadOnly = False
        TextBox16.ReadOnly = False
        TextBox17.ReadOnly = False
        TextBox18.ReadOnly = False
        Button10.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox12.Visible = True
        ComboBox3.Visible = False
        TextBox14.ReadOnly = True
        TextBox14.Visible = True
        DateTimePicker2.Visible = False
        TextBox15.ReadOnly = True
        TextBox16.ReadOnly = True
        TextBox17.ReadOnly = True
        TextBox18.ReadOnly = True
        Button10.Visible = False
        str2 = "Update ADD_BOOK set AUT_NAME ='" & TextBox11.Text & "', DEPT = '" & ComboBox3.Text & "', ADD_DT ='" & DateTimePicker2.Value.ToShortDateString & "', B_PRICE =" & TextBox15.Text & ", PUBLI ='" & TextBox16.Text & "', CATE ='" & TextBox17.Text & "', PAG = " & TextBox18.Text & " where B_ID = '" & TextBox10.Text & "'"
        obj.cmd.CommandText = str2
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteReader()
        obj.cn.Close()
        MsgBox("RECORD UPDATE SUCESSFULLY")
        TextBox10.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ComboBox4.Visible = False
        TextBox24.Visible = True
        TextBox23.ReadOnly = True
        TextBox25.ReadOnly = True
        TextBox25.Visible = True
        Button12.Visible = False
        DateTimePicker3.Visible = False
        str5 = "Update ISSUE_BOOK set ISS_NM = '" & TextBox23.Text & "', ISS_TYPE = '" & ComboBox4.Text & "', ISS_DT = '" & DateTimePicker3.Value.ToShortDateString & "' where ISS_ID = '" & TextBox19.Text & "'"
        obj.cmd.CommandText = str5
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteReader()
        obj.cn.Close()
        MsgBox("RECORD UPDATE SUCESSFULLY")
        TextBox19.Text = ""
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        str3 = "select * from ADD_BOOK where B_ID = '" & TextBox10.Text & "'"
        obj.cmd.CommandText = str3
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox11.Text = obj.dr.Item(2)
            TextBox12.Text = obj.dr.Item(6)
            TextBox13.Text = obj.dr.Item(1)
            TextBox14.Text = obj.dr.Item(4)
            TextBox15.Text = obj.dr.Item(5)
            TextBox16.Text = obj.dr.Item(7)
            TextBox17.Text = obj.dr.Item(8)
            TextBox18.Text = obj.dr.Item(9)
        Else
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""
            TextBox18.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        str4 = "select * from ISSUE_BOOK where ISS_ID = '" & TextBox19.Text & "'"
        obj.cmd.CommandText = str4
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox20.Text = obj.dr.Item(1)
            TextBox21.Text = obj.dr.Item(2)
            TextBox22.Text = obj.dr.Item(3)
            TextBox23.Text = obj.dr.Item(4)
            TextBox24.Text = obj.dr.Item(5)
            TextBox25.Text = obj.dr.Item(6)
        Else
            TextBox20.Text = ""
            TextBox21.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
            TextBox24.Text = ""
            TextBox25.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox3.Visible = True
        GroupBox2.Visible = False
        GroupBox1.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ComboBox4.Visible = True
        TextBox24.Visible = False
        TextBox23.ReadOnly = False
        TextBox25.ReadOnly = False
        TextBox25.Visible = False
        Button12.Visible = True
        DateTimePicker3.Visible = True
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button3.Visible = True
        ComboBox1.Visible = True
        TextBox3.Visible = False
        TextBox3.ReadOnly = False
        DateTimePicker1.Visible = True
        TextBox4.Visible = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        ComboBox2.Visible = True
        TextBox7.Visible = False
        TextBox8.ReadOnly = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        ComboBox1.Visible = False
        TextBox3.Visible = True
        TextBox3.ReadOnly = True
        DateTimePicker1.Visible = False
        TextBox4.Visible = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        ComboBox2.Visible = False
        TextBox7.Visible = True
        TextBox8.ReadOnly = True
        str = "Update ADD_USER set DEPT ='" & ComboBox1.Text & "', DATE_BAT = '" & DateTimePicker1.Value.ToShortDateString & "', ADDR = '" & TextBox5.Text & "', MOB_NO = '" & TextBox6.Text & "', TYPE = '" & ComboBox2.Text & "',S_YEAR = '" & TextBox8.Text & "' where ROLL_NO = '" & TextBox1.Text & "'"
        obj.cmd.CommandText = str
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteReader()
        obj.cn.Close()
        MsgBox("RECORD UPDATE SUCESSFULLY")
        TextBox1.Text = ""
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Secondform As New Form2
        Secondform.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        str1 = " Select * from ADD_USER where ROLL_NO ='" & TextBox1.Text & "'"
        obj.cmd.CommandText = str1
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.dr = obj.cmd.ExecuteReader
        If obj.dr.Read = True Then
            TextBox2.Text = obj.dr.Item(1)
            TextBox3.Text = obj.dr.Item(3)
            TextBox4.Text = obj.dr.Item(4)
            TextBox5.Text = obj.dr.Item(5)
            TextBox6.Text = obj.dr.Item(6)
            TextBox7.Text = obj.dr.Item(7)
            TextBox8.Text = obj.dr.Item(8)
            TextBox9.Text = obj.dr.Item(9)
        Else
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
        End If
        obj.dr.Close()
        obj.cn.Close()
    End Sub
End Class


