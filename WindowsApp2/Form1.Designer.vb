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
        Me.CarListBox = New System.Windows.Forms.ListBox()
        Me.ModelListBox = New System.Windows.Forms.ListBox()
        Me.ColorType = New System.Windows.Forms.ListBox()
        Me.Color = New System.Windows.Forms.ListBox()
        Me.EngineType = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarListBox
        '
        Me.CarListBox.FormattingEnabled = True
        Me.CarListBox.Items.AddRange(New Object() {"Audi", "Skoda", "Honda", "Porsche", "Chevrolet"})
        Me.CarListBox.Location = New System.Drawing.Point(86, 129)
        Me.CarListBox.Name = "CarListBox"
        Me.CarListBox.Size = New System.Drawing.Size(120, 95)
        Me.CarListBox.TabIndex = 0
        '
        'ModelListBox
        '
        Me.ModelListBox.FormattingEnabled = True
        Me.ModelListBox.Location = New System.Drawing.Point(212, 129)
        Me.ModelListBox.Name = "ModelListBox"
        Me.ModelListBox.Size = New System.Drawing.Size(120, 95)
        Me.ModelListBox.TabIndex = 0
        '
        'ColorType
        '
        Me.ColorType.FormattingEnabled = True
        Me.ColorType.Location = New System.Drawing.Point(464, 129)
        Me.ColorType.Name = "ColorType"
        Me.ColorType.Size = New System.Drawing.Size(120, 95)
        Me.ColorType.TabIndex = 0
        '
        'Color
        '
        Me.Color.FormattingEnabled = True
        Me.Color.Location = New System.Drawing.Point(590, 129)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(120, 95)
        Me.Color.TabIndex = 0
        '
        'EngineType
        '
        Me.EngineType.FormattingEnabled = True
        Me.EngineType.Location = New System.Drawing.Point(338, 129)
        Me.EngineType.Name = "EngineType"
        Me.EngineType.Size = New System.Drawing.Size(120, 95)
        Me.EngineType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Marka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Silnik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lakier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Kolor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(410, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 617)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EngineType)
        Me.Controls.Add(Me.Color)
        Me.Controls.Add(Me.ColorType)
        Me.Controls.Add(Me.ModelListBox)
        Me.Controls.Add(Me.CarListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarListBox As ListBox
    Friend WithEvents ModelListBox As ListBox
    Friend WithEvents ColorType As ListBox
    Friend WithEvents Color As ListBox
    Friend WithEvents EngineType As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
