<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Page
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
        SignUpButton = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        FullNameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        EmailIdTextBox = New TextBox()
        GoToLoginPage = New LinkLabel()
        ShowPassword = New CheckBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        ErrorProvider4 = New ErrorProvider(components)
        UserTextBox = New TextBox()
        Label6 = New Label()
        ErrorProvider5 = New ErrorProvider(components)
        RePassTextBox = New TextBox()
        Label7 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        SignUpButton.Location = New Point(294, 420)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(94, 37)
        SignUpButton.TabIndex = 0
        SignUpButton.Text = "Sign Up"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(45, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(726, 86)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME BACK!!" & vbCrLf & "                             Please enter your Details: " & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(168, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 39)
        Label3.TabIndex = 3
        Label3.Text = "Password : "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(168, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 38)
        Label4.TabIndex = 4
        Label4.Text = "Email Id : "
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(157, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 41)
        Label5.TabIndex = 5
        Label5.Text = "Full Name : "
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FullNameTextBox.Location = New Point(427, 112)
        FullNameTextBox.Multiline = True
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.PlaceholderText = "Enter your name"
        FullNameTextBox.Size = New Size(284, 43)
        FullNameTextBox.TabIndex = 6
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PasswordTextBox.Location = New Point(427, 285)
        PasswordTextBox.Multiline = True
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.PlaceholderText = "Enter your password"
        PasswordTextBox.Size = New Size(284, 39)
        PasswordTextBox.TabIndex = 9
        ' 
        ' EmailIdTextBox
        ' 
        EmailIdTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        EmailIdTextBox.Location = New Point(427, 232)
        EmailIdTextBox.Multiline = True
        EmailIdTextBox.Name = "EmailIdTextBox"
        EmailIdTextBox.PlaceholderText = "Enter your email id"
        EmailIdTextBox.Size = New Size(284, 38)
        EmailIdTextBox.TabIndex = 10
        ' 
        ' GoToLoginPage
        ' 
        GoToLoginPage.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        GoToLoginPage.Location = New Point(220, 476)
        GoToLoginPage.Name = "GoToLoginPage"
        GoToLoginPage.Size = New Size(241, 30)
        GoToLoginPage.TabIndex = 11
        GoToLoginPage.TabStop = True
        GoToLoginPage.Text = "Have an account? Sign In"
        ' 
        ' ShowPassword
        ' 
        ShowPassword.AutoSize = True
        ShowPassword.Location = New Point(631, 386)
        ShowPassword.Name = "ShowPassword"
        ShowPassword.Size = New Size(132, 24)
        ShowPassword.TabIndex = 12
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
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' ErrorProvider4
        ' 
        ErrorProvider4.ContainerControl = Me
        ' 
        ' UserTextBox
        ' 
        UserTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        UserTextBox.Location = New Point(427, 174)
        UserTextBox.Multiline = True
        UserTextBox.Name = "UserTextBox"
        UserTextBox.PlaceholderText = "Enter your username"
        UserTextBox.Size = New Size(284, 43)
        UserTextBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(157, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 41)
        Label6.TabIndex = 14
        Label6.Text = "User Name : "
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ErrorProvider5
        ' 
        ErrorProvider5.ContainerControl = Me
        ' 
        ' RePassTextBox
        ' 
        RePassTextBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        RePassTextBox.Location = New Point(427, 341)
        RePassTextBox.Multiline = True
        RePassTextBox.Name = "RePassTextBox"
        RePassTextBox.PasswordChar = "*"c
        RePassTextBox.PlaceholderText = "Enter your password"
        RePassTextBox.Size = New Size(284, 39)
        RePassTextBox.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(67, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(221, 39)
        Label7.TabIndex = 16
        Label7.Text = "Confirmed Password : "
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Register_Page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 557)
        Controls.Add(Label7)
        Controls.Add(RePassTextBox)
        Controls.Add(Label6)
        Controls.Add(UserTextBox)
        Controls.Add(ShowPassword)
        Controls.Add(GoToLoginPage)
        Controls.Add(EmailIdTextBox)
        Controls.Add(PasswordTextBox)
        Controls.Add(FullNameTextBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(SignUpButton)
        Name = "Register_Page"
        Text = "Register_Page"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SignUpButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents RePassTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailIdTextBox As TextBox
    Friend WithEvents GoToLoginPage As LinkLabel
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RePasswordTextBox As TextBox
    Friend WithEvents ErrorProvider5 As ErrorProvider
End Class
