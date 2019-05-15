Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports WindowsApp2

Public Class Form1
    'Private objTabela As DataTable
    'Private ds_Brands As DataSet
    'Private ds_Models As DataSet
    'Private ds_Engines As DataSet
    'Private ds_Colors As DataSet
    'Private ds_Equipment As DataSet
    Private DBPath As String
    Private delegacja As addNewItemToDB

    '
    Delegate Sub addNewItemToDB(ByRef itemName As String)

    Public Sub New()
        InitializeComponent()

        DBPath = "D:\Kody\Git\TK2\WindowsApp2\Database1.mdf"

        Dim conn As SqlConnection
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim dataadapter As SqlDataAdapter
        Dim objTabela As DataTable
        Dim ds_Brands As DataSet
        dataadapter = New SqlDataAdapter

        ds_Brands = New DataSet

        Dim sql_getBrands As New SqlCommand("SELECT * FROM Brands")

        dataadapter.SelectCommand = sql_getBrands
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Brands, "Brands")

        'objTabela = New DataTable
        objTabela = ds_Brands.Tables("Brands")
        CarList.Items.Clear()
        'objTabela.Rows.Item(0)("BrandName").ToString

        For Each row In objTabela.Rows
            CarList.Items.Add(row("BrandName"))
        Next row

        'Tworzenie delegacji
        delegacja = New addNewItemToDB(AddressOf addNewBrand)
    End Sub

    'Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
    '   GroupBox1.Visible = False
    '   LoginButton.Visible = True
    '   LogoutButton.Visible = False
    '  GroupBox2.Visible = True
    'End Sub


    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        reload()
    End Sub

    Private Sub ModelList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModelList.SelectedIndexChanged

        EngineType.Items.Clear()
        EqTypeList.Items.Clear()
        ColorList.Items.Clear()

        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim getEngineType_query As New SqlCommand("SELECT EngineType FROM Engines WHERE
            Model_ID = (SELECT Model_ID FROM Models WHERE ModelName = '" & ModelList.SelectedItem & "')")
        'Dim getEqTypeList_query As New SqlCommand("SELECT CarEq FROM Equipment WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        'Dim getColorType_query As New SqlCommand("SELECT ColorType FROM Colors WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim objTabela As New DataTable

        dataadapter.SelectCommand = getEngineType_query
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds, "EngineType")
        objTabela = ds.Tables("EngineType")
        For Each row In objTabela.Rows
            EngineType.Items.Add(row("EngineType"))
        Next row

        'dataadapter.SelectCommand = getEqTypeList_query
        'dataadapter.SelectCommand.Connection = conn
        'dataadapter.Fill(ds, "CarEq")
        'objTabela = ds.Tables("CarEq")
        'For Each row In objTabela.Rows
        'EqTypeList.Items.Add(row("CarEq"))
        'Next row



        conn.Close()
    End Sub

    Private Sub EngineType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EngineType.SelectedIndexChanged
        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim sql_Query As New SqlCommand("SELECT C.CarEq FROM Equipment C, Brands B, Models M, Engines E
            WHERE C.Brand_ID = B.Brand_ID
            AND C.Model_ID = M.Model_ID
            AND C.Engine_ID = E.Engine_ID")
        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim objTabela As New DataTable

        dataadapter.SelectCommand = sql_Query
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds, "CarEq")

        objTabela = ds.Tables("CarEq")
        EqTypeList.Items.Clear()

        For Each row In objTabela.Rows
            EqTypeList.Items.Add(row("CarEq"))
        Next row
        conn.Close()
    End Sub

    Private Sub EqTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EqTypeList.SelectedIndexChanged
        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim sql_Query As New SqlCommand("SELECT C.Color, C.ColorType FROM Colors C, Brands B, Models M, Equipment E
            WHERE C.Brand_ID = B.Brand_ID
            AND C.Model_ID = M.Model_ID
            AND C.Eq_ID = E.Eq_ID")
        Dim dataAdapter As New SqlDataAdapter
        Dim ds_Color As New DataSet
        Dim ds_ColorType As New DataSet
        Dim objTabela As New DataTable
        Dim dt_ColorType As New DataTable

        dataAdapter.SelectCommand = sql_Query
        dataAdapter.SelectCommand.Connection = conn
        dataAdapter.Fill(ds_Color, "Color")
        dataAdapter.Fill(ds_ColorType, "ColorType")

        objTabela = ds_Color.Tables("Color")
        dt_ColorType = ds_ColorType.Tables("ColorType")
        ColorList.Items.Clear()

        Dim j As Int16
        j = 0
        For Each row In objTabela.Rows
            ColorList.Items.Add(row("Color") & " (" & dt_ColorType.Rows.Item(j).Item(1) & ")")
            j = j + 1
        Next row
        conn.Close()
    End Sub

    Private Sub ColorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColorList.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim fileName As String
        Dim filePath As String
        Dim OpenFile As OpenFileDialog = New OpenFileDialog()

        OpenFile.InitialDirectory = "D:"
        OpenFile.Filter = "mdf files (*.mdf)|*.mdf|All files (*.*)|*.*"
        OpenFile.FilterIndex = 2
        OpenFile.RestoreDirectory = True

        If OpenFile.ShowDialog() = DialogResult.OK Then

            'Get the path of specified file
            filePath = OpenFile.FileName
            DBName.Text = OpenFile.FileName
            DBPath = filePath
            reload()
        End If
    End Sub

    Private Function reload()
        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim sql_Query As New SqlCommand("SELECT ModelName FROM Models WHERE Brand_ID =
            (SELECT Brand_ID FROM Brands WHERE BrandName = '" & CarList.SelectedItem & "')")
        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim objTabela As New DataTable

        dataadapter.SelectCommand = sql_Query
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds, "Models")

        objTabela = ds.Tables("Models")
        ModelList.Items.Clear()
        EngineType.Items.Clear()
        ColorList.Items.Clear()
        EqTypeList.Items.Clear()

        For Each row In objTabela.Rows
            ModelList.Items.Add(row("ModelName"))
        Next row
        conn.Close()
    End Function

    Private Sub LoginFormButton_Click(sender As Object, e As EventArgs) Handles LoginFormButton.Click

        LoginFormButton.Enabled = False
        Dim LoginForm As New Form2(DBPath)
        If LoginForm.ShowDialog = DialogResult.OK And LoginForm.Label1.Text = "Granted" Then
            GroupBox1.Show()
            LoginFormButton.Hide()
            LogoutButton.Show()
        Else
            LoginFormButton.Enabled = True
        End If



    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LoginFormButton.Enabled = True
        LoginFormButton.Show()
        LogoutButton.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub AddNewItemButton_Click(sender As Object, e As EventArgs) Handles AddNewItemButton.Click
        If AddNewItemBox.Text <> "" Then
            delegacja(AddNewItemBox.Text)
        End If
    End Sub

    Private Sub addNewBrand(ByRef itemName As String)
        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"

        conn.Open()
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        da.SelectCommand = New SqlCommand("SELECT * FROM Brands")
        da.InsertCommand = New SqlCommand("INSERT INTO Brands (BrandName) VALUES ('" & itemName & "')")
        da.SelectCommand.Connection = conn
        da.InsertCommand.Connection = conn
        da.Fill(ds, "Brands")
        Dim dt As DataTable = ds.Tables("Brands")

        For Each row In dt.Rows
            If row("BrandName") = itemName Then
                MsgBox("Podana marka istnieje już w bazie danych !")
                Exit Sub
            End If
        Next row

        Dim newRow As DataRow
        newRow = dt.NewRow()
        'newRow("Brand_ID") = ""
        newRow("BrandName") = itemName
        dt.Rows.Add(newRow)
        da.Update(ds, "Brands")
        CarList.Items.Add(itemName)
        AddNewItemBox.Clear()
        'CarList.Sorted = True
        'query()
    End Sub

    Private Sub addNewModel(ByRef itemName As String)
        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"

        conn.Open()
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet


        da.SelectCommand = New SqlCommand("SELECT * FROM Models")
        da.SelectCommand.Connection = conn

        da.Fill(ds, "Models")
        Dim dt As DataTable = ds.Tables("Models")

        'Pobieramy producenta
        Dim daBrandID As New SqlDataAdapter
        Dim dsBrandID As New DataSet

        daBrandID.SelectCommand = New SqlCommand("SELECT Brand_ID FROM Brands WHERE BrandName = '" & CarList.SelectedItem.ToString & "'")
        daBrandID.SelectCommand.Connection = conn
        daBrandID.Fill(dsBrandID, "Brands")

        Dim dtBrandID As DataTable = dsBrandID.Tables("Brands")

        For Each row In dt.Rows
            If row("ModelName") = itemName Then
                MsgBox("Podany model istnieje już w bazie danych !")
                Exit Sub
            End If
        Next row

        Dim newRow As DataRow
        newRow = dt.NewRow()
        'newRow("ModelName") = itemName
        'newRow("Brand_ID") = dtBrandID.Rows(0)("Brand_ID")

        da.InsertCommand = New SqlCommand("INSERT INTO Models (ModelName, Brand_ID) VALUES ('" & itemName & "', '" & dtBrandID.Rows(0)("Brand_ID") & "')")
        da.InsertCommand.Connection = conn
        dt.Rows.Add(newRow)
        da.Update(ds, "Models")
        ModelList.Items.Add(itemName)
        AddNewItemBox.Clear()
    End Sub

    Private Sub addNewEngine(ByRef itemName As String)

        If ModelList.SelectedIndex = -1 Then
            MsgBox("Nie wybrano modelu !")
            Exit Sub
        End If

        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"

        conn.Open()
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet


        da.SelectCommand = New SqlCommand("SELECT * FROM Engines")
        da.SelectCommand.Connection = conn

        da.Fill(ds, "Engines")
        Dim dt As DataTable = ds.Tables("Engines")

        'Pobieramy model
        Dim daModelID As New SqlDataAdapter
        Dim dsModelID As New DataSet

        daModelID.SelectCommand = New SqlCommand("SELECT Model_ID FROM Models WHERE ModelName = '" & ModelList.SelectedItem.ToString & "'")
        daModelID.SelectCommand.Connection = conn
        daModelID.Fill(dsModelID, "Models")

        Dim dtModelID As DataTable = dsModelID.Tables("Models")

        For Each row In dt.Rows
            If row("Enginetype") = itemName Then
                MsgBox("Podany model silnika istnieje już w bazie danych !")
                Exit Sub
            End If
        Next row

        Dim newRow As DataRow
        newRow = dt.NewRow()
        da.InsertCommand = New SqlCommand("INSERT INTO Engines (EngineType, Model_ID) VALUES ('" & itemName & "', '" & dtModelID.Rows(0)("Model_ID") & "')")
        da.InsertCommand.Connection = conn
        dt.Rows.Add(newRow)
        da.Update(ds, "Engines")
        EngineType.Items.Add(itemName)
        AddNewItemBox.Clear()
    End Sub

    Private Function query(sqlQuery As String)
        Dim conn As New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim _query As New SqlCommand(sqlQuery)

        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim objTabela As New DataTable

        dataadapter.SelectCommand = _query
        dataadapter.SelectCommand.Connection = conn
        Return 1
    End Function

    Private Sub BrandRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BrandRadioButton.CheckedChanged
        delegacja = New addNewItemToDB(AddressOf addNewBrand)
    End Sub

    Private Sub ModelRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ModelRadioButton.CheckedChanged
        delegacja = New addNewItemToDB(AddressOf addNewModel)
    End Sub

    Private Sub EngineRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EngineRadioButton.CheckedChanged
        delegacja = New addNewItemToDB(AddressOf addNewEngine)
    End Sub

    Private Sub EqRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EqRadioButton.CheckedChanged

    End Sub

    Private Sub ColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ColorRadioButton.CheckedChanged

    End Sub
End Class
