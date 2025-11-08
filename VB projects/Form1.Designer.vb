<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        LoginButton = New Button()
        buttonCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RegisterLink = New LinkLabel()
        EmailOrUserTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        ShowPassword = New CheckBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoginButton
        ' 
        LoginButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LoginButton.Location = New Point(275, 309)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(94, 37)
        LoginButton.TabIndex = 0
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' buttonCancel
        ' 
        buttonCancel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        buttonCancel.Location = New Point(446, 309)
        buttonCancel.Name = "buttonCancel"
        buttonCancel.Size = New Size(94, 37)
        buttonCancel.TabIndex = 1
        buttonCancel.Text = "Cancel"
        buttonCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(110, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 43)
        Label1.TabIndex = 2
        Label1.Text = "Email Id or User Name: "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(218, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 41)
        Label2.TabIndex = 3
        Label2.Text = "Password : "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(43, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(726, 85)
        Label3.TabIndex = 4
        Label3.Text = "Welcome Back!!" & vbCrLf & "                                        Please enter your details" & vbCrLf & vbCrLf
        ' 
        ' RegisterLink
        ' 
        RegisterLink.AutoSize = True
        RegisterLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        RegisterLink.Location = New Point(234, 371)
        RegisterLink.Name = "RegisterLink"
        RegisterLink.Size = New Size(353, 28)
        RegisterLink.TabIndex = 5
        RegisterLink.TabStop = True
        RegisterLink.Text = "Don't have an Account? Register Now"
        ' 
        ' EmailOrUserTextBox
        ' 
        EmailOrUserTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        EmailOrUserTextBox.Location = New Point(446, 128)
        EmailOrUserTextBox.Multiline = True
        EmailOrUserTextBox.Name = "EmailOrUserTextBox"
        EmailOrUserTextBox.PlaceholderText = "Enter Email Id or User Name"
        EmailOrUserTextBox.Size = New Size(275, 43)
        EmailOrUserTextBox.TabIndex = 6
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PasswordTextBox.Location = New Point(446, 199)
        PasswordTextBox.Multiline = True
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.PlaceholderText = "Enter Password"
        PasswordTextBox.Size = New Size(275, 41)
        PasswordTextBox.TabIndex = 7
        ' 
        ' ShowPassword
        ' 
        ShowPassword.AutoSize = True
        ShowPassword.Location = New Point(625, 246)
        ShowPassword.Name = "ShowPassword"
        ShowPassword.Size = New Size(132, 24)
        ShowPassword.TabIndex = 8
        ShowPassword.Text = "Show Password"
        ShowPassword.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 450)
        Controls.Add(ShowPassword)
        Controls.Add(PasswordTextBox)
        Controls.Add(EmailOrUserTextBox)
        Controls.Add(RegisterLink)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(buttonCancel)
        Controls.Add(LoginButton)
        Name = "Form1"
        Text = "Login Page"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RegisterLink As LinkLabel
    Friend WithEvents EmailOrUserTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
