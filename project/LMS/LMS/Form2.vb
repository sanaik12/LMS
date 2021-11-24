Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '//NEW FORM 2 TO FORM 3 SHOW CODE'
        Dim f3 As New Form3
        f3.Show()
        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '//NEW FORM 2 TO FORM 4 SHOW CODE'
        Dim f4 As New Form4
        f4.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f8 As New Form8
        Form8.Show()
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f5 As New Form5
        f5.Show()
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f7 As New Form7
        f7.Show()
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '//FORM 2 LOGOUT BOTTOM CODE'
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '//PICTURE FORM 2 TO FORM 3 SHOW CODE'
        Dim f3 As New Form3
        f3.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '//PICTURE FORM 2 TO FORM 4 SHOW CODE'
        Dim f4 As New Form4
        f4.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim f5 As New Form5
        f5.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim f7 As New Form7
        f7.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim f8 As New Form8
        Form8.Show()
        Me.Visible = False
    End Sub
End Class