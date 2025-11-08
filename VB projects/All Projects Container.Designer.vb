<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Projects_Container
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
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Panel2 = New Panel()
        LinkLabel2 = New LinkLabel()
        Panel3 = New Panel()
        LinkLabel3 = New LinkLabel()
        Panel4 = New Panel()
        LinkLabel4 = New LinkLabel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(63, 99)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 125)
        Panel1.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(50, 18)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(138, 86)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Simple Calculator"
        LinkLabel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(LinkLabel2)
        Panel2.Location = New Point(371, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 125)
        Panel2.TabIndex = 1
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.Location = New Point(41, 18)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(168, 86)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Student Marks Calculator"
        LinkLabel2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(LinkLabel3)
        Panel3.Location = New Point(63, 275)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 125)
        Panel3.TabIndex = 2
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel3.Location = New Point(50, 21)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(138, 84)
        LinkLabel3.TabIndex = 1
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "NotePad"
        LinkLabel3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(LinkLabel4)
        Panel4.Location = New Point(371, 275)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 125)
        Panel4.TabIndex = 1
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.BackColor = Color.White
        LinkLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel4.Location = New Point(41, 21)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(168, 84)
        LinkLabel4.TabIndex = 1
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Login And Registation Page"
        LinkLabel4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(624, 45)
        Label1.TabIndex = 3
        Label1.Text = "PROJECTS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' All_Projects_Container
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(685, 434)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "All_Projects_Container"
        Text = "All_Projects_Container"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
