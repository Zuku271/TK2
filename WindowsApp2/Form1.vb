Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1
    'Private objTabela As DataTable
    'Private ds_Brands As DataSet
    'Private ds_Models As DataSet
    'Private ds_Engines As DataSet
    'Private ds_Colors As DataSet
    'Private ds_Equipment As DataSet
    '

    Public Sub New()
        InitializeComponent()
        Dim conn As SqlConnection
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
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
    End Sub


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim objTabela As DataTable
        Dim dataset As DataSet
        Dim dataadapter As SqlDataAdapter
        Dim sql_Command As New SqlCommand("SELECT * FROM Users WHERE Login='" & LoginBox.Text & "' AND Password='" & PasswordBox.Text & "';")


        Dim conn As SqlConnection
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        dataadapter = New SqlDataAdapter
        dataset = New DataSet
        dataadapter.SelectCommand = sql_Command
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(dataset, "Users")

        objTabela = New DataTable
        objTabela = dataset.Tables("Users")

        If objTabela.Rows.Count = 1 Then
            'MsgBox("Zalogowano !")
            GroupBox1.Visible = True
            LoginButton.Visible = False
            LogoutButton.Visible = True
            GroupBox2.Visible = False

            LoginBox.Clear()
            PasswordBox.Clear()
        Else
            MsgBox("Niepoprawne dane.")
        End If
        conn.Close()

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        GroupBox1.Visible = False
        LoginButton.Visible = True
        LogoutButton.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim sql_Query As New SqlCommand("SELECT ModelName FROM MODELS WHERE Brand_ID = '" & CarList.SelectedIndex & "';")
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
        ColorTypeList.Items.Clear()
        EqTypeList.Items.Clear()

        For Each row In objTabela.Rows
            ModelList.Items.Add(row("ModelName"))
        Next row
        conn.Close()
    End Sub

    Private Sub ModelList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModelList.SelectedIndexChanged

        EngineType.Items.Clear()
        EqTypeList.Items.Clear()

        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim getEngineType_query As New SqlCommand("SELECT EngineType FROM Engines WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim getEqTypeList_query As New SqlCommand("SELECT CarEq FROM Equipment WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim getColorType_query As New SqlCommand("SELECT ColorType FROM Colors WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
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

        dataadapter.SelectCommand = getEqTypeList_query
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds, "CarEq")
        objTabela = ds.Tables("CarEq")
        For Each row In objTabela.Rows
            EqTypeList.Items.Add(row("CarEq"))
        Next row



        conn.Close()
    End Sub

    Private Sub EngineType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EngineType.SelectedIndexChanged
        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim sql_Query As New SqlCommand("SELECT EngineType FROM Engines WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim objTabela As New DataTable

        dataadapter.SelectCommand = sql_Query
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds, "EngineType")

        objTabela = ds.Tables("EngineType")
        EngineType.Items.Clear()

        For Each row In objTabela.Rows
            EngineType.Items.Add(row("EngineType"))
        Next row
        conn.Close()
    End Sub

    Private Sub ColorTypeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColorTypeList.SelectedIndexChanged
        EngineType.Items.Clear()
        EqTypeList.Items.Clear()

        Dim conn As SqlConnection
        conn = New SqlConnection

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        Dim getEngineType_query As New SqlCommand("SELECT EngineType FROM Engines WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim getEqTypeList_query As New SqlCommand("SELECT CarEq FROM Equipment WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
        Dim getColorType_query As New SqlCommand("SELECT ColorType FROM Colors WHERE Brand_ID = '" & CarList.SelectedIndex & "' AND Model_ID = '" & ModelList.SelectedIndex & "';")
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
        conn.Close()
    End Sub
End Class
