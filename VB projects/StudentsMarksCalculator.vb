Public Class StudentsMarksCalculator
    Private Sub StudentsMarksCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpScience.Visible = False
        grpHumanity.Visible = False
        grpCommerce.Visible = False
        grpresultshow.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioScience.CheckedChanged
        If True Then
            grpScience.Visible = True
            grpHumanity.Visible = False
            grpCommerce.Visible = False
            grpresultshow.Visible = False
            CenterGroupBox(grpScience)
        End If
    End Sub

    Private Sub RadioCommerce_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCommerce.CheckedChanged
        If True Then
            grpCommerce.Visible = True
            grpScience.Visible = False
            grpHumanity.Visible = False
            grpresultshow.Visible = False
            CenterGroupBox(grpCommerce)
        End If
    End Sub

    Private Sub RadioHumanity_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHumanity.CheckedChanged
        If True Then
            grpHumanity.Visible = True
            grpScience.Visible = False
            grpCommerce.Visible = False
            grpresultshow.Visible = False
            CenterGroupBox(grpHumanity)
        End If
    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click
        Dim total As Integer
        Dim percentage As Double
        grpresultshow.Visible = True
        Try
            If grpScience.Visible = True Then
                total = Val(SEnglishTextBox.Text) + Val(CSTextBox.Text) + Val(SMathsTextBox.Text) + Val(PhysicsTextBox.Text) + Val(ChemistryTextBox.Text)
            ElseIf grpCommerce.Visible = True Then
                total = Val(CEnglishTextBox.Text) + Val(EconomicsTextBox.Text) + Val(AccountsTextBox.Text) + Val(ITTextBox.Text) + Val(CMathsTextBox.Text)
            ElseIf grpHumanity.Visible = True Then
                total = Val(HindiTextBox.Text) + Val(HEnglishTextBox.Text) + Val(HistoryTextBox.Text) + Val(GeographyTextBox.Text) + Val(PolityTextBox.Text)
            End If

            If total < 0 Or total > 500 Then
                MessageBox.Show("Please enter valid marks between 0 and 100 for each subject.")
                Return
            End If

            percentage = (total / 500) * 100

            MarksObtained.Text = total.ToString()
            GradeShow.Text = GetGrade(total)
            PercentageShow.Text = percentage.ToString("F2") & "%"

        Catch ex As Exception
            MessageBox.Show("Please enter valid marks (0-100) in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetGrade(total As Integer) As String
        Dim avg As Double = total / 5.0

        Select Case avg
            Case >= 90
                Return "A+"
            Case >= 80
                Return "A"
            Case >= 70
                Return "B"
            Case >= 60
                Return "C"
            Case >= 50
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function


    Private Sub CenterGroupBox(gb As GroupBox)
        gb.Left = (Me.ClientSize.Width - gb.Width) \ 2
    End Sub

End Class