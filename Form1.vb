Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Coca-Cola 1.5L" Then
            TextBox1.Text = "65"
        ElseIf ComboBox1.Text = "Fanta Lemon Bottles 1.5L" Then
            TextBox1.Text = "72"
        ElseIf ComboBox1.Text = "Sprite 1.5L" Then
            TextBox1.Text = "64"
        ElseIf ComboBox1.Text = "Coke Zero 500ml" Then
            TextBox1.Text = "29"
        ElseIf ComboBox1.Text = "Mountain Dew 1.5L" Then
            TextBox1.Text = "65"
        ElseIf ComboBox1.Text = "Royal 1.5L" Then
            TextBox1.Text = "70"
        ElseIf ComboBox1.Text = "Pepsi 1.5L" Then
            TextBox1.Text = "78"
        ElseIf ComboBox1.Text = "Gatorade(Glass Bottle)" Then
            TextBox1.Text = "15"
        ElseIf ComboBox1.Text = "Root Beer 100ml" Then
            TextBox1.Text = "20"
        ElseIf ComboBox1.Text = "Cobra Energy Drink" Then
            TextBox1.Text = "11"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox6.Text = Val(TextBox5.Text) - Val(TextBox4.Text)
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


End Class