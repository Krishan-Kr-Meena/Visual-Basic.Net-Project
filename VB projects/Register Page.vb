Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Register_Page

    Private Sub FullNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FullNameTextBox.TextChanged
        If String.IsNullOrEmpty(FullNameTextBox.Text) Then
            ErrorProvider1.SetError(FullNameTextBox, "Full name is required.")
        Else
            ErrorProvider1.SetError(FullNameTextBox, "")
        End If
    End Sub

    Private Sub EmailIdTextBox_Leave(sender As Object, e As EventArgs) Handles EmailIdTextBox.Leave
        If String.IsNullOrEmpty(EmailIdTextBox.Text) Then
            ErrorProvider2.SetError(EmailIdTextBox, "Email ID is required.")
        Else
            ErrorProvider2.SetError(EmailIdTextBox, "")
        End If
    End Sub

    Private Sub UserTextBox_Leave(sender As Object, e As EventArgs) Handles UserTextBox.Leave
        If String.IsNullOrEmpty(UserTextBox.Text) Then
            ErrorProvider3.SetError(UserTextBox, "Username is required.")
        Else
            ErrorProvider3.SetError(UserTextBox, "")
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            ErrorProvider4.SetError(PasswordTextBox, "Password is required.")
        Else
            ErrorProvider4.SetError(PasswordTextBox, "")
        End If
    End Sub

    Private Sub RePassTextBox_Leave(sender As Object, e As EventArgs) Handles RePassTextBox.Leave
        If String.IsNullOrEmpty(RePassTextBox.Text) Then
            ErrorProvider5.SetError(RePassTextBox, "Please re-enter your password.")
        ElseIf PasswordTextBox.Text <> RePassTextBox.Text Then
            ErrorProvider5.SetError(RePassTextBox, "Passwords do not match.")
        Else
            ErrorProvider5.SetError(RePassTextBox, "")
        End If
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            PasswordTextBox.PasswordChar = ""
            'RePassTextBox.PasswordChar = ""
            RePassTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
            'RePassTextBox.PasswordChar = "*"
            RePassTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        ' Basic validation before proceeding
        If String.IsNullOrEmpty(FullNameTextBox.Text) Then
            MessageBox.Show("Full name is empty")
        ElseIf String.IsNullOrEmpty(EmailIdTextBox.Text) Then
            MessageBox.Show("Email ID is empty")
        ElseIf String.IsNullOrEmpty(UserTextBox.Text) Then
            MessageBox.Show("Username is empty")
        ElseIf String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Password is empty")
        ElseIf String.IsNullOrEmpty(RePassTextBox.Text) Then
            MessageBox.Show("Confirm password is empty")
        Else
            ' Continue with registration
        End If



        If PasswordTextBox.Text <> RePassTextBox.Text Then
            MessageBox.Show("Passwords do not match. Please try again.")
            Exit Sub
        End If

        ' Insert data into Access DB
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Database1.accdb"

        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO Table3 (Full Name, Email id, Password, Username) VALUES (?, ?, ?, ?)"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", FullNameTextBox.Text)
                    cmd.Parameters.AddWithValue("?", EmailIdTextBox.Text)
                    cmd.Parameters.AddWithValue("?", PasswordTextBox.Text)
                    cmd.Parameters.AddWithValue("?", UserTextBox.Text)


                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registration successful!")
                        All_Projects_Container.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Registration failed. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during registration: " & ex.Message)
        End Try
    End Sub

    Private Sub GoToLoginPage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GoToLoginPage.LinkClicked
        Dim login As New Form1()
        login.Show()
    End Sub

End Class
