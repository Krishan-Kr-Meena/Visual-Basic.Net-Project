'Imports System.Data.OleDb
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Data

Public Class Form1

    Private Sub EmailOrUserTextBox_Leave(sender As Object, e As EventArgs) Handles EmailOrUserTextBox.Leave
        If String.IsNullOrEmpty(EmailOrUserTextBox.Text) Then
            MessageBox.Show("Please enter a Email Id or Username")
            ErrorProvider1.SetError(EmailOrUserTextBox, "Email Id or Username is required.")
        Else
            ErrorProvider1.SetError(EmailOrUserTextBox, "")
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Please enter a password.")
            ErrorProvider2.SetError(PasswordTextBox, "Password is required.")
        Else
            ErrorProvider2.SetError(PasswordTextBox, "")
        End If
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Ensure the required namespace is imported and the types are recognized
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Database1.accdb")
        con.Open()
        Dim query As String = "SELECT * FROM Table3 WHERE (EmailID = @emailid OR Username = @username) AND Password = @password"
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@emailid", EmailOrUserTextBox.Text)
        cmd.Parameters.AddWithValue("@username", EmailOrUserTextBox.Text)
        cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login successful!")
            Dim projects As New All_Projects_Container()
            projects.Show()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub RegisterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLink.LinkClicked
        Dim register As New Register_Page()
        register.Show()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        Me.Close()
    End Sub

End Class