Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

    Private CarList As ArrayList = New ArrayList()
    Private ModelList As ArrayList = New ArrayList()
    Private EngineList As ArrayList = New ArrayList()
    Private ColorList As ArrayList = New ArrayList()

    Dim FileList() As FileInfo

    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarListBox.SelectedIndexChanged
        ModelListBox.Items.Clear()

        If CarListBox.SelectedItem = "Audi" Then
            ModelListBox.Items.Add("A1")
            ModelListBox.Items.Add("A3")

        ElseIf CarListBox.SelectedItem = "Honda" Then
            ModelListBox.Items.Add("Civic")
            ModelListBox.Items.Add("CRV")

        ElseIf CarListBox.SelectedItem = "Porsche" Then
            ModelListBox.Items.Add("718")
            ModelListBox.Items.Add("911")

        ElseIf CarListBox.SelectedItem = "Chevrolet" Then
            ModelListBox.Items.Add("Cruze")
            ModelListBox.Items.Add("Camaro")
        End If
    End Sub

    Private Sub ModelList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModelListBox.SelectedIndexChanged
        EngineType.Items.Clear()
        ColorType.Items.Clear()
        Color.Items.Clear()

        If ModelListBox.SelectedItem = "A1" Then
            A1ModelSelected()
        ElseIf ModelListBox.SelectedItem = "A3" Then
            A3ModelSelected()
        ElseIf ModelListBox.SelectedItem = "Civic" Then
            CivicModelSelected()
        ElseIf ModelListBox.SelectedItem = "CRV" Then
            CRVModelSelected()

        End If
    End Sub

    Private Sub A1ModelSelected()
        EngineType.Items.Add("2.0 TSI")
        EngineType.Items.Add("2.5 TFSI")
        ColorType.Items.Add("Normalny")
        ColorType.Items.Add("Metalik")

        Dim id As String = "A1"
        Dim folder As String = "D:\"
        Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
        PictureBox1.Image = Image.FromFile(filename)
    End Sub

    Private Sub A3ModelSelected()
        EngineType.Items.Add("2.0 TSI")
        EngineType.Items.Add("3.0 TFSI")
        ColorType.Items.Add("Normalny")
        ColorType.Items.Add("Metalik")

        Dim id As String = "A3"
        Dim folder As String = "D:\"
        Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
        PictureBox1.Image = Image.FromFile(filename)
    End Sub

    Private Sub CivicModelSelected()
        EngineType.Items.Add("1.0 VTEC Turbo")
        EngineType.Items.Add("1.5 VTEC Turbo")
        ColorType.Items.Add("Normalny")
        ColorType.Items.Add("Metalik")
    End Sub

    Private Sub CRVModelSelected()
        EngineType.Items.Add("2.0 i-VTEC Turbo")
        EngineType.Items.Add("1.6 i-DTEC 4WD")
        ColorType.Items.Add("Normalny")
        ColorType.Items.Add("Metalik")
    End Sub

End Class
