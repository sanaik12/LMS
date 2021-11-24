Imports System.Data.OleDb
Public Class Form4
    Dim obj As New CONNECTION
    Dim str, str1, str2, str3, str4 As String
    Dim a, b, c, d, e As Integer

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '// Refresh botton code'
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str2 = "insert into ADD_USER values(" & TextBox8.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox2.Text & "','" & TextBox7.Text & "'," & TextBox3.Text & ")"
        obj.cmd.CommandText = str2
        obj.cmd.Connection = obj.cn
        obj.cn.Open()
        obj.cmd.ExecuteNonQuery()
        obj.cn.Close()
        MsgBox("RECORD ADDED SUCCESSFULLY")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        a = a + 1
        TextBox8.Text = a
        ComboBox1.Text = "SELECT ONE"
        ComboBox2.Text = "SELECT ONE"
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "M&S-"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "CSE-"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "MECH-"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "CIV-"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "ELE-"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "MET-"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            str1 = "select count(*) from ADD_USER where DEPT='" & ComboBox1.Text & "'"
            obj.cmd.CommandText = str1
            obj.cmd.Connection = obj.cn
            obj.cn.Open()
            obj.dr = obj.cmd.ExecuteReader
            obj.dr.Close()
            obj.cn.Close()
            TextBox2.Text = "ETC-"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '//FORM 4 BACK BUTTON CODE'
        Dim SecondForm As New Form2
        SecondForm.Show()
        Me.Hide()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        str = "select count(*) from ADD_USER"
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
    End Sub
End Class