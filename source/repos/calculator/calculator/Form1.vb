Public Class Form1
    Public curval As Double
    Public preval As Double
    Public reset As Double
    Public choice As String

    Private Sub mixedControls_Click(sender As Object, e As EventArgs) Handles Button15.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        TextBox1.Text = TextBox1.Text & sender.tabindex
        curval = Val(TextBox1.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        curval = Val(TextBox1.Text)
        TextBox1.Text = Nothing
        preval = curval
        choice = "+"
        curval = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        curval = Val(TextBox1.Text)
        TextBox1.Text = Nothing
        preval = curval
        choice = "-"
        curval = 0
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        curval = Val(TextBox1.Text)
        TextBox1.Text = Nothing
        preval = curval
        choice = "/"
        curval = 0
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        curval = Val(TextBox1.Text)
        TextBox1.Text = Nothing
        preval = curval
        choice = "X"
        curval = 0
    End Sub

End Class
