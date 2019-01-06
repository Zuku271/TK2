<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginName = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LoginTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 131)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logowanie"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(50, 92)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Zapisz"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(50, 54)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(156, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hasło:"
        '
        'LoginTextBox
        '
        Me.LoginTextBox.Location = New System.Drawing.Point(50, 23)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(156, 20)
        Me.LoginTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Login:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Zalogowany jako:"
        Me.Label1.Visible = False
        '
        'LoginName
        '
        Me.LoginName.AutoSize = True
        Me.LoginName.Location = New System.Drawing.Point(109, 9)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(35, 13)
        Me.LoginName.TabIndex = 11
        Me.LoginName.Text = "Name"
        Me.LoginName.Visible = False
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(15, 25)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.Text = "Wyloguj"
        Me.LogoutButton.UseVisualStyleBackColor = True
        Me.LogoutButton.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.LoginName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 500)
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginName As Label
    Friend WithEvents LogoutButton As Button
End Class
