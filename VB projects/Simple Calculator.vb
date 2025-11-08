Public Class Simple_Calculator

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "x"
        TextBox1.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "%"
        TextBox1.Text = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        operand1.Text = TextBox1.Text
        Operation.Text = "^"
        TextBox1.Text = ""
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        operand1.Text = ""
        Operand2.Text = ""
        Operation.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click
        Operand2.Text = TextBox1.Text
        Select Case Operation.Text
            Case "+"
                TextBox1.Text = Val(operand1.Text) + Val(Operand2.Text)
            Case "-"
                TextBox1.Text = Val(operand1.Text) - Val(Operand2.Text)
            Case "x"
                TextBox1.Text = Val(operand1.Text) * Val(Operand2.Text)
            Case "/"
                If Operand2.Text <> "0" Then
                    TextBox1.Text = Val(operand1.Text) / Val(Operand2.Text)
                Else
                    MessageBox.Show("Cannot divide by zero.")
                End If
            Case "%"
                TextBox1.Text = Val(operand1.Text) Mod Val(Operand2.Text)
            Case "^"
                TextBox1.Text = Math.Pow(Val(operand1.Text), Val(Operand2.Text))
        End Select
    End Sub


End Class