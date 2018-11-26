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

        Dim con As SqlConnection
        con = New SqlConnection
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kody\Git\TK2\WindowsApp2\Database1.mdf;Integrated Security=True;Connect Timeout=30"

        'sqlBuilder = New SqlCommandBuilder(dataadapter)
        'cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=..\Debug\Database1.mdf"

        'conn = New System.Data.SqlClient.SqlConnection(cnString)
        'conn.Open()


        'Dim objZapytanie As New System.Data.SqlClient.SqlConnection(strSQL, conn)

    End Sub
End Class
