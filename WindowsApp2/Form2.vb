Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form2
    Private dBPath As String

    Public Sub New(dBPath As String)
        InitializeComponent()
        Me.dBPath = dBPath


    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs)

        Dim objTabela As DataTable
        Dim dataset As DataSet
        Dim dataadapter As SqlDataAdapter
        Dim sql_Command As New SqlCommand("SELECT * FROM Users WHERE Login='" & LoginBox.Text & "' AND Password='" & PasswordBox.Text & "';")


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
            'MsgBox("Zalogowano !")
            'GroupBox1.Visible = True
            LoginButton.Visible = False
            ' LogoutButton.Visible = True
            GroupBox2.Visible = False

            LoginBox.Clear()
            PasswordBox.Clear()
        Else
            MsgBox("Niepoprawne dane.")
        End If
        conn.Close()

    End Sub
End Class