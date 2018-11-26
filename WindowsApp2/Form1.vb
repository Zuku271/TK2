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

        Dim query_string As String
        query_string = "SELECT * FROM Users WHERE Login = '" & LoginBox.Text & "' AND Password = '" & PasswordBox.Text & "';"
        dataadapter = New SqlDataAdapter()
        dataadapter.SelectCommand = New SqlCommand(query_string)
        'Dim sqlBuilder As SqlCommandBuilder
        Dim SqlConnectionString As String = "Server=;" & "DataBase=..\Database1.mdf;" & "Integrated Security=SSPI"
        Dim sql_Connection = New SqlConnection(SqlConnectionString)
        sql_Connection.Open()
        dataadapter = New SqlDataAdapter()
        'sqlBuilder = New SqlCommandBuilder(dataadapter)
        'cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=..\Debug\Database1.mdf"

        'conn = New System.Data.SqlClient.SqlConnection(cnString)
        'conn.Open()


        'Dim objZapytanie As New System.Data.SqlClient.SqlConnection(strSQL, conn)

    End Sub
End Class
