<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CarList = New System.Windows.Forms.ListBox()
        Me.ModelList = New System.Windows.Forms.ListBox()
        Me.ColorList = New System.Windows.Forms.ListBox()
        Me.EngineType = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BrandRadioButton = New System.Windows.Forms.RadioButton()
        Me.ModelRadioButton = New System.Windows.Forms.RadioButton()
        Me.EngineRadioButton = New System.Windows.Forms.RadioButton()
        Me.EqRadioButton = New System.Windows.Forms.RadioButton()
        Me.ColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddNewItemBox = New System.Windows.Forms.TextBox()
        Me.AddNewItemButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoadDbButton = New System.Windows.Forms.Button()
        Me.EqTypeList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChangeDB = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DBName = New System.Windows.Forms.TextBox()
        Me.LoginFormButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ChangeDB.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarList
        '
        Me.CarList.FormattingEnabled = True
        Me.CarList.Location = New System.Drawing.Point(45, 291)
        Me.CarList.Name = "CarList"
        Me.CarList.Size = New System.Drawing.Size(120, 95)
        Me.CarList.TabIndex = 0
        '
        'ModelList
        '
        Me.ModelList.FormattingEnabled = True
        Me.ModelList.Location = New System.Drawing.Point(171, 291)
        Me.ModelList.Name = "ModelList"
        Me.ModelList.Size = New System.Drawing.Size(120, 95)
        Me.ModelList.TabIndex = 0
        '
        'ColorList
        '
        Me.ColorList.FormattingEnabled = True
        Me.ColorList.Location = New System.Drawing.Point(549, 291)
        Me.ColorList.Name = "ColorList"
        Me.ColorList.Size = New System.Drawing.Size(120, 95)
        Me.ColorList.TabIndex = 0
        '
        'EngineType
        '
        Me.EngineType.FormattingEnabled = True
        Me.EngineType.Location = New System.Drawing.Point(297, 291)
        Me.EngineType.Name = "EngineType"
        Me.EngineType.Size = New System.Drawing.Size(120, 95)
        Me.EngineType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Marka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Silnik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(546, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Kolor"
        '
        'BrandRadioButton
        '
        Me.BrandRadioButton.AutoSize = True
        Me.BrandRadioButton.Checked = True
        Me.BrandRadioButton.Location = New System.Drawing.Point(226, 38)
        Me.BrandRadioButton.Name = "BrandRadioButton"
        Me.BrandRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.BrandRadioButton.TabIndex = 6
        Me.BrandRadioButton.TabStop = True
        Me.BrandRadioButton.Text = "Marka"
        Me.BrandRadioButton.UseVisualStyleBackColor = True
        '
        'ModelRadioButton
        '
        Me.ModelRadioButton.AutoSize = True
        Me.ModelRadioButton.Location = New System.Drawing.Point(226, 61)
        Me.ModelRadioButton.Name = "ModelRadioButton"
        Me.ModelRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.ModelRadioButton.TabIndex = 6
        Me.ModelRadioButton.Text = "Model"
        Me.ModelRadioButton.UseVisualStyleBackColor = True
        '
        'EngineRadioButton
        '
        Me.EngineRadioButton.AutoSize = True
        Me.EngineRadioButton.Location = New System.Drawing.Point(226, 84)
        Me.EngineRadioButton.Name = "EngineRadioButton"
        Me.EngineRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.EngineRadioButton.TabIndex = 6
        Me.EngineRadioButton.Text = "Silnik"
        Me.EngineRadioButton.UseVisualStyleBackColor = True
        '
        'EqRadioButton
        '
        Me.EqRadioButton.AutoSize = True
        Me.EqRadioButton.Location = New System.Drawing.Point(226, 107)
        Me.EqRadioButton.Name = "EqRadioButton"
        Me.EqRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.EqRadioButton.TabIndex = 6
        Me.EqRadioButton.Text = "Wyposażenie"
        Me.EqRadioButton.UseVisualStyleBackColor = True
        '
        'ColorRadioButton
        '
        Me.ColorRadioButton.AutoSize = True
        Me.ColorRadioButton.Location = New System.Drawing.Point(226, 130)
        Me.ColorRadioButton.Name = "ColorRadioButton"
        Me.ColorRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.ColorRadioButton.TabIndex = 6
        Me.ColorRadioButton.Text = "Kolor"
        Me.ColorRadioButton.UseVisualStyleBackColor = True
        '
        'AddNewItemBox
        '
        Me.AddNewItemBox.Location = New System.Drawing.Point(10, 38)
        Me.AddNewItemBox.Name = "AddNewItemBox"
        Me.AddNewItemBox.Size = New System.Drawing.Size(183, 20)
        Me.AddNewItemBox.TabIndex = 3
        '
        'AddNewItemButton
        '
        Me.AddNewItemButton.Location = New System.Drawing.Point(10, 70)
        Me.AddNewItemButton.Name = "AddNewItemButton"
        Me.AddNewItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewItemButton.TabIndex = 7
        Me.AddNewItemButton.Text = "Dodaj"
        Me.AddNewItemButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddNewItemButton)
        Me.GroupBox1.Controls.Add(Me.AddNewItemBox)
        Me.GroupBox1.Controls.Add(Me.ColorRadioButton)
        Me.GroupBox1.Controls.Add(Me.BrandRadioButton)
        Me.GroupBox1.Controls.Add(Me.ModelRadioButton)
        Me.GroupBox1.Controls.Add(Me.EqRadioButton)
        Me.GroupBox1.Controls.Add(Me.EngineRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 222)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dodawanie danych"
        Me.GroupBox1.Visible = False
        '
        'LoadDbButton
        '
        Me.LoadDbButton.Location = New System.Drawing.Point(45, 401)
        Me.LoadDbButton.Name = "LoadDbButton"
        Me.LoadDbButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadDbButton.TabIndex = 2
        Me.LoadDbButton.Text = "Wczytaj"
        Me.LoadDbButton.UseVisualStyleBackColor = True
        Me.LoadDbButton.Visible = False
        '
        'EqTypeList
        '
        Me.EqTypeList.FormattingEnabled = True
        Me.EqTypeList.Location = New System.Drawing.Point(423, 291)
        Me.EqTypeList.Name = "EqTypeList"
        Me.EqTypeList.Size = New System.Drawing.Size(120, 95)
        Me.EqTypeList.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(420, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Wyposażenie"
        '
        'ChangeDB
        '
        Me.ChangeDB.Controls.Add(Me.Button1)
        Me.ChangeDB.Controls.Add(Me.DBName)
        Me.ChangeDB.Location = New System.Drawing.Point(45, 457)
        Me.ChangeDB.Name = "ChangeDB"
        Me.ChangeDB.Size = New System.Drawing.Size(624, 100)
        Me.ChangeDB.TabIndex = 10
        Me.ChangeDB.TabStop = False
        Me.ChangeDB.Text = "Zmiana komisu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zmień"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DBName
        '
        Me.DBName.Location = New System.Drawing.Point(6, 24)
        Me.DBName.Name = "DBName"
        Me.DBName.Size = New System.Drawing.Size(612, 20)
        Me.DBName.TabIndex = 3
        Me.DBName.Text = "D:\Kody\Git\TK2\WindowsApp2\Database1.mdf"
        '
        'LoginFormButton
        '
        Me.LoginFormButton.Location = New System.Drawing.Point(45, 39)
        Me.LoginFormButton.Name = "LoginFormButton"
        Me.LoginFormButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginFormButton.TabIndex = 11
        Me.LoginFormButton.Text = "Logowanie"
        Me.LoginFormButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(45, 68)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 11
        Me.LogoutButton.Text = "Wyloguj"
        Me.LogoutButton.UseVisualStyleBackColor = True
        Me.LogoutButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 562)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.LoginFormButton)
        Me.Controls.Add(Me.ChangeDB)
        Me.Controls.Add(Me.LoadDbButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EqTypeList)
        Me.Controls.Add(Me.EngineType)
        Me.Controls.Add(Me.ColorList)
        Me.Controls.Add(Me.ModelList)
        Me.Controls.Add(Me.CarList)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1060, 600)
        Me.MinimumSize = New System.Drawing.Size(1060, 600)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ChangeDB.ResumeLayout(False)
        Me.ChangeDB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarList As ListBox
    Friend WithEvents ModelList As ListBox
    Friend WithEvents ColorList As ListBox
    Friend WithEvents EngineType As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BrandRadioButton As RadioButton
    Friend WithEvents ModelRadioButton As RadioButton
    Friend WithEvents EngineRadioButton As RadioButton
    Friend WithEvents EqRadioButton As RadioButton
    Friend WithEvents ColorRadioButton As RadioButton
    Friend WithEvents AddNewItemBox As TextBox
    Friend WithEvents AddNewItemButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoadDbButton As Button
    Friend WithEvents EqTypeList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChangeDB As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DBName As TextBox
    Friend WithEvents LoginFormButton As Button
    Friend WithEvents LogoutButton As Button
End Class
