Public Class Form1
    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        ModelList.Items.Clear()

        If CarList.SelectedItem = "Audi" Then
            ModelList.Items.Add("A1")
            ModelList.Items.Add("A3")
            ModelList.Items.Add("A4")
            ModelList.Items.Add("A5")

        ElseIf CarList.SelectedItem = "Skoda" Then
            ModelList.Items.Add("Octavia")
            ModelList.Items.Add("Rapid")
            ModelList.Items.Add("Superb")

        ElseIf CarList.SelectedItem = "Honda" Then
            ModelList.Items.Add("Civic")
            ModelList.Items.Add("Accord")
            ModelList.Items.Add("CR-V")
            ModelList.Items.Add("HR-V")

        ElseIf CarList.SelectedItem = "Porsche" Then
            ModelList.Items.Add("Macan")
            ModelList.Items.Add("718")
            ModelList.Items.Add("911")

        ElseIf CarList.SelectedItem = "Chevrolet" Then
            ModelList.Items.Add("Cruze")
            ModelList.Items.Add("Camaro")
        End If
    End Sub
End Class
