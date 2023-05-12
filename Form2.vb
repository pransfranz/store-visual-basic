Public Class Form2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Succesful Login")
            Hide()
            Form1.Show()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click

    End Sub
End Class