Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form2
    Private dBPath As String

    Public Sub New(dBPath As String)
        InitializeComponent()
        Me.dBPath = dBPath


    End Sub



    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim objTabela As DataTable
        Dim dataset As DataSet
        Dim dataadapter As SqlDataAdapter
        Dim sql_Command As New SqlCommand("SELECT * FROM Users WHERE Login='" & LoginTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "';")


        Dim conn As SqlConnection
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & dBPath & ";Integrated Security=True;Connect Timeout=30"
        conn.Open()

        dataadapter = New SqlDataAdapter
        dataset = New DataSet
        dataadapter.SelectCommand = sql_Command
        dataadapter.SelectCommand.Connection = conn
        dataadapter.Fill(dataset, "Users")

        objTabela = New DataTable
        objTabela = dataset.Tables("Users")

        If objTabela.Rows.Count = 1 Then
            Label1.Text = "Granted"
            'LoginTextBox.Clear()
            'PasswordTextBox.Clear()

        Else
            MsgBox("Niepoprawne dane.")
        End If
        conn.Close()
    End Sub

End Class