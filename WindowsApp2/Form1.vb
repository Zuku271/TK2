Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1
    Private objTabela As DataTable
    Private ds_Brands As DataSet
    Private ds_Models As DataSet
    Private ds_Engines As DataSet
    Private ds_Colors As DataSet
    Private ds_Equipment As DataSet
    Private dataadapter As SqlDataAdapter

    Public Sub New()
        InitializeComponent()
        Dim conn As SqlConnection
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"
        conn.Open()

        dataadapter = New SqlDataAdapter

        ds_Brands = New DataSet
        ds_Models = New DataSet
        ds_Engines = New DataSet
        ds_Colors = New DataSet
        ds_Equipment = New DataSet

        Dim sql_getBrands As New SqlCommand("SELECT * FROM Brands")
        Dim sql_getModels As New SqlCommand("SELECT * FROM Models")
        Dim sql_getEngines As New SqlCommand("SELECT * FROM Engines")
        Dim sql_getColors As New SqlCommand("SELECT * FROM Colors")
        Dim sql_getEquipment As New SqlCommand("SELECT * FROM Equipment")

        dataadapter.SelectCommand = sql_getBrands
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Brands, "Brands")

        dataadapter.SelectCommand = sql_getModels
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Models, "Models")

        dataadapter.SelectCommand = sql_getEngines
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Engines, "Engines")

        dataadapter.SelectCommand = sql_getColors
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Colors, "Colors")

        dataadapter.SelectCommand = sql_getEquipment
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(ds_Equipment, "Equipment")

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
        End If
        conn.Close()

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        GroupBox1.Visible = False
        LoginButton.Visible = True
        LogoutButton.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub LoadDbButton_Click(sender As Object, e As EventArgs) Handles LoadDbButton.Click

    End Sub

    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        ModelList.Items.Clear()


    End Sub
End Class
