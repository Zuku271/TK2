Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

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

End Class
