
Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Item1" Then
            TextBox1.Text = "5"
        ElseIf ComboBox1.Text = "Item2" Then
            TextBox1.Text = "290"
        ElseIf ComboBox1.Text = "Item3" Then
            TextBox1.Text = "25"
        ElseIf ComboBox1.Text = "Item4" Then
            TextBox1.Text = "70"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox6.Text = Val(TextBox5.Text) - Val(TextBox4.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        With ListView1.Items.Insert(0, ComboBox1.Text, 0)
            .SubItems.Add(TextBox1.Text)
            .SubItems.Add(TextBox2.Text)
            .SubItems.Add(TextBox3.Text)
        End With
        TextBox4.Text = Val(TextBox4.Text) + Val(TextBox3.Text)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With ListView1.Items.Insert(0, ComboBox1.Text, 0)
            .SubItems.Add(TextBox1.Text)
            .SubItems.Add(TextBox2.Text)
            .SubItems.Add(TextBox3.Text)
        End With
        TextBox4.Text = Val(TextBox4.Text) + Val(TextBox3.Text)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Form2.Show()
    End Sub

End Class
