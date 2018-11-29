Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim cnString As String

        Dim objTabela As DataTable
        Dim objWiersz As DataRow
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
        Dim objRow As DataRow
        For Each objRow In objTabela.Rows
            MsgBox(objRow("Login"))
        Next objRow
        conn.Close()


    End Sub
End Class
