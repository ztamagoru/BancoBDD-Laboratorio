Imports System.Data.SqlClient

Public Class Class1
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dataadapter As New SqlDataAdapter
    Public dataset As New DataSet
    Public connError As String

    Public Sub New()
        Try
            conn.ConnectionString = "Server=DESKTOP-ULVBESH\SQLEXPRESS;Database=cupiniuwu;Integrated Security=true;User Id=test;Password=wasd1234;"
            conn.Open()

            cmd.Connection = conn

            connError = ""
        Catch ex As Exception
            connError = ex.Message
        End Try
    End Sub

    Public Sub execute(comando As String)
        Try
            cmd.CommandText = comando
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try
    End Sub
End Class
