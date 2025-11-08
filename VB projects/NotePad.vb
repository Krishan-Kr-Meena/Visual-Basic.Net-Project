Imports System.IO
'Imports Microsoft.Office.Interop.Excel
Imports System.Drawing


Public Class NotePad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
        RichTextBox1.Visible = True
        If Not RichTextBox1.Text = "" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the current file?", "Save", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                SaveFileDialog1.ShowDialog()
            ElseIf result = DialogResult.Cancel Then
                Return
            End If

        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        RichTextBox1.Clear()
        RichTextBox1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim searchText As String = InputBox("Enter text to find:", "Find")
        If Not String.IsNullOrEmpty(searchText) Then
            Dim startIndex As Integer = RichTextBox1.Find(searchText)
            If startIndex <> -1 Then
                RichTextBox1.Select(startIndex, searchText.Length)
                RichTextBox1.ScrollToCaret()
            Else
                MessageBox.Show("Text not found.")
            End If
        End If
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click

    End Sub

    Private Sub FontSizeStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontSizeStyleToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub

    Private Sub InseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InseToolStripMenuItem.Click
        RichTextBox1.SelectedText = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss")
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim saveFile As New StreamWriter(SaveFileDialog1.FileName)
        saveFile.Write(RichTextBox1.Text)
        saveFile.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim openFile As New StreamReader(OpenFileDialog1.FileName)
        RichTextBox1.Text = openFile.ReadToEnd()
        openFile.Close()
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        Dim currentSize As Single = RichTextBox1.Font.Size
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, currentSize + 2)
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Dim currentSize As Single = RichTextBox1.Font.Size
        If currentSize > 2 Then
            RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, currentSize - 2)
        End If
    End Sub

    Private Sub RestoreAllDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreAllDefaultToolStripMenuItem.Click
        Dim currentFont As Font = RichTextBox1.Font
        RichTextBox1.Font = New Font(currentFont.FontFamily, 12.0F, currentFont.Style)
    End Sub

End Class