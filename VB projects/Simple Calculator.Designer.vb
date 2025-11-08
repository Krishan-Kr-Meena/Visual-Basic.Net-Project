<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simple_Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        operand1 = New TextBox()
        Operand2 = New TextBox()
        TextBox1 = New TextBox()
        Operation = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        ResultButton = New Button()
        ClearButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label1.Location = New Point(42, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(772, 65)
        Label1.TabIndex = 0
        Label1.Text = "Calculator"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' operand1
        ' 
        operand1.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        operand1.Location = New Point(42, 94)
        operand1.Multiline = True
        operand1.Name = "operand1"
        operand1.Size = New Size(329, 62)
        operand1.TabIndex = 1
        ' 
        ' Operand2
        ' 
        Operand2.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Operand2.Location = New Point(506, 94)
        Operand2.Multiline = True
        Operand2.Name = "Operand2"
        Operand2.Size = New Size(308, 62)
        Operand2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        TextBox1.Location = New Point(153, 172)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(486, 53)
        TextBox1.TabIndex = 3
        ' 
        ' Operation
        ' 
        Operation.AccessibleRole = AccessibleRole.WhiteSpace
        Operation.BackColor = SystemColors.ScrollBar
        Operation.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Operation.Location = New Point(400, 94)
        Operation.Name = "Operation"
        Operation.Size = New Size(82, 62)
        Operation.TabIndex = 4
        Operation.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label3.Location = New Point(67, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 53)
        Label3.TabIndex = 5
        Label3.Text = "+"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label4.Location = New Point(179, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 53)
        Label4.TabIndex = 6
        Label4.Text = "-"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Silver
        Label5.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label5.Location = New Point(67, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 53)
        Label5.TabIndex = 7
        Label5.Text = "x"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Silver
        Label6.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label6.Location = New Point(179, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 53)
        Label6.TabIndex = 8
        Label6.Text = "/"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Silver
        Label7.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label7.Location = New Point(67, 378)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 53)
        Label7.TabIndex = 9
        Label7.Text = "Mod"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Silver
        Label8.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label8.Location = New Point(179, 378)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 53)
        Label8.TabIndex = 10
        Label8.Text = "^"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Silver
        Label9.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label9.Location = New Point(490, 252)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 53)
        Label9.TabIndex = 11
        Label9.Text = "7"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Silver
        Label10.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label10.Location = New Point(618, 252)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 53)
        Label10.TabIndex = 12
        Label10.Text = "8"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Silver
        Label11.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label11.Location = New Point(742, 252)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 53)
        Label11.TabIndex = 13
        Label11.Text = "9"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Silver
        Label12.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label12.Location = New Point(490, 316)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 53)
        Label12.TabIndex = 14
        Label12.Text = "4"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.Silver
        Label13.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label13.Location = New Point(618, 316)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 53)
        Label13.TabIndex = 15
        Label13.Text = "5"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.Silver
        Label14.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label14.Location = New Point(742, 316)
        Label14.Name = "Label14"
        Label14.Size = New Size(72, 53)
        Label14.TabIndex = 16
        Label14.Text = "6"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.Silver
        Label15.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label15.Location = New Point(490, 378)
        Label15.Name = "Label15"
        Label15.Size = New Size(72, 53)
        Label15.TabIndex = 17
        Label15.Text = "1"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.BackColor = Color.Silver
        Label16.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label16.Location = New Point(618, 378)
        Label16.Name = "Label16"
        Label16.Size = New Size(72, 53)
        Label16.TabIndex = 18
        Label16.Text = "2"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.BackColor = Color.Silver
        Label17.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label17.Location = New Point(742, 378)
        Label17.Name = "Label17"
        Label17.Size = New Size(72, 53)
        Label17.TabIndex = 19
        Label17.Text = "3"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.BackColor = Color.Silver
        Label18.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label18.Location = New Point(490, 441)
        Label18.Name = "Label18"
        Label18.Size = New Size(72, 53)
        Label18.TabIndex = 20
        Label18.Text = "."
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.BackColor = Color.Silver
        Label19.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        Label19.Location = New Point(618, 441)
        Label19.Name = "Label19"
        Label19.Size = New Size(196, 53)
        Label19.TabIndex = 21
        Label19.Text = "0"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ResultButton
        ' 
        ResultButton.BackColor = SystemColors.ActiveCaption
        ResultButton.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        ResultButton.Location = New Point(228, 518)
        ResultButton.Name = "ResultButton"
        ResultButton.Size = New Size(124, 55)
        ResultButton.TabIndex = 22
        ResultButton.Text = "Result"
        ResultButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = SystemColors.ActiveCaption
        ClearButton.Font = New Font("Maiandra GD", 12F, FontStyle.Bold)
        ClearButton.Location = New Point(400, 518)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(113, 55)
        ClearButton.TabIndex = 23
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' Simple_Calculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 585)
        Controls.Add(ClearButton)
        Controls.Add(ResultButton)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Operation)
        Controls.Add(TextBox1)
        Controls.Add(Operand2)
        Controls.Add(operand1)
        Controls.Add(Label1)
        Name = "Simple_Calculator"
        Text = "Simple_Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents operand1 As TextBox
    Friend WithEvents Operand2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Operation As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ResultButton As Button
    Friend WithEvents ClearButton As Button
End Class
