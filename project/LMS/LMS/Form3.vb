Imports System.Data.OleDb
Public Class Form3
    Dim obj As New CONNECTION
    Dim str, str1, str2, str3, str4 As String
    Dim a, b, c, d, e As Integer

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str2 = "insert into ADD_BOOK values(" & TextBox8.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox10.Text & "'," & TextBox4.Text & ",'" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "')"
        obj.cmd.CommandText = str2
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteNonQuery()
        obj.cn.Close()
        str3 = "insert into STOCK values('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox4.Text & ",'" & TextBox10.Text & "')"
        obj.cmd.CommandText = str3
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteNonQuery()
        obj.cn.Close()
        MsgBox("RECORD ADDED SUCCESSFULLY")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        a = a + 1
        TextBox8.Text = a
        TextBox3.Text = ""
        ComboBox1.Text = "SELECT ONE"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '//FORM 3 REFRESH BUTTON CODE'
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '//BACK BUTTON CODE'
        Dim SecondForm As New Form2
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//FORM 3 SERIAL NO AUTO GERANATED CODE'
        str = "select count(*) from ADD_BOOK"
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
        TextBox8.Text = a
        TextBox10.Text = DateAndTime.Today
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '//FORM 3 COMBOBOX CODE' 
        If ComboBox1.SelectedIndex = 0 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "M&S-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "CSE-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "MECH-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "CIV-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 4 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "ELE-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 5 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "MET-" + CType(b, String)
        ElseIf ComboBox1.SelectedIndex = 6 Then
            str1 = "select count(*) from ADD_BOOK where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            If obj.dr.Read = True Then
                b = obj.dr.Item(0) + 1
            Else b = 1
            End If
            obj.dr.Close()
            obj.cn.Close()
            TextBox3.Text = "ETC-" + CType(b, String)
        End If


    End Sub
End Class