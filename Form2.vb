Public Class Form2

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Succesful Login")
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub
End Class