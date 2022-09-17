Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comando As String

        Try
            comando = "SELECT * FROM Client"
            conexion.execute(comando)

            MsgBox("Success", vbOK)

            refresh()

        Catch ex As Exception
            comando = "CREATE TABLE Client(" + vbCrLf +
                "idClient int identity(1,1) primary key" + vbCrLf +
                ", FullName varchar(250) not null" + vbCrLf +
                ", DNI varchar(50) not null" + vbCrLf +
                ", Cellphone varchar(50) not null" + vbCrLf +
                ", Descubierto varchar(50) not null" + vbCrLf +
                ")"

            conexion.execute(comando)

            MsgBox("Table created", vbOK)

            If conexion.connError <> "" Then
                MsgBox(conexion.connError, vbOK)
            End If
        End Try
    End Sub

    Sub refresh()
        conexion.dataset = New DataSet

        Try
            conexion.execute("SELECT * FROM Client")

            conexion.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conexion.cmd)
            conexion.dataadapter.Fill(conexion.dataset)

            DataGridView1.DataSource = conexion.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////

    Private Sub BttnInsertar_Click(sender As Object, e As EventArgs) Handles bttnInsertar.Click
        Dim comando As String

        conexion = New Class1
        If TBoxName.Text.Trim = String.Empty Or TBoxDNI.Text.Trim = String.Empty Or
                TBoxCellphone.Text.Trim = String.Empty Or TBoxDescubierto.Text.Trim = String.Empty Then

            MsgBox("Error. Cannot leave blank spaces.", vbOK)

        Else
            Try
                comando = "INSERT INTO Client" + vbCrLf +
                    "VALUES (" + vbCrLf +
                    "'" + TBoxName.Text.Trim + "'" + vbCrLf +
                    ", '" + TBoxDNI.Text.Trim + "'" + vbCrLf +
                    ", '" + TBoxCellphone.Text.Trim + "'" + vbCrLf +
                    ", '" + TBoxDescubierto.Text.Trim + "'" + vbCrLf +
                    ")"

                conexion.execute(comando)

                MsgBox("Success.", vbOK)

                clear()
            Catch ex As Exception
                MsgBox("Error." + vbCrLf + ex.Message, vbOK)

                Return
            End Try

            refresh()
        End If
    End Sub

    Private Sub bttnVaciar_Click(sender As Object, e As EventArgs) Handles bttnVaciar.Click
        clear()
    End Sub

    Sub clear()
        TBoxidClient.Clear()
        TBoxName.Clear()
        TBoxDNI.Clear()
        TBoxCellphone.Clear()
        TBoxDescubierto.Clear()
    End Sub

    Private Sub bttnConsultar_Click(sender As Object, e As EventArgs) Handles bttnConsultar.Click
        complete()
    End Sub

    Sub complete()
        TBoxidClient.Text = DataGridView1.CurrentRow.Cells(0).Value
        TBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value
        TBoxDNI.Text = DataGridView1.CurrentRow.Cells(2).Value
        TBoxCellphone.Text = DataGridView1.CurrentRow.Cells(3).Value
        TBoxDescubierto.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub bttnModificar_Click(sender As Object, e As EventArgs) Handles bttnModificar.Click
        Dim comando As String

        If TBoxidClient.Text = String.Empty Then

            MsgBox("Error." + vbCrLf + "Consult a value to be able to modify it.", vbOK)

        Else
            If MsgBox("Do you wish to continue?", vbYesNo) = 6 Then
                conexion = New Class1

                Try
                    comando = "UPDATE Client" + vbCrLf +
                        "SET FullName = '" + TBoxName.Text.Trim + "'" + vbCrLf +
                        ", DNI = '" + TBoxDNI.Text.Trim + "'" + vbCrLf +
                        ", Cellphone = '" + TBoxCellphone.Text.Trim + "'" + vbCrLf +
                        ", Descubierto = '" + TBoxDescubierto.Text.Trim + "'" + vbCrLf +
                        "WHERE idClient = " + TBoxidClient.Text

                    conexion.execute(comando)

                    MsgBox("Values modified successfully.", vbOK)
                Catch ex As Exception
                    MsgBox("Error." + vbCrLf + ex.Message, vbOK)

                    Return
                End Try
            End If

            refresh()
            clear()
        End If
    End Sub

    Private Sub bttnBorrar_Click(sender As Object, e As EventArgs) Handles bttnBorrar.Click
        Dim comando As String

        If TBoxidClient.Text = String.Empty Then

            MsgBox("Error." + vbCrLf + "Consult a value to be able to remove it.", vbOK)

        Else
            If MsgBox("Do you wish to continue?", vbYesNo) = 6 Then
                conexion = New Class1

                Try
                    comando = "DELETE FROM Client" + vbCrLf +
                        "WHERE idClient = " + TBoxidClient.Text

                    conexion.execute(comando)

                    MsgBox("Values removed successfully.", vbOK)
                Catch ex As Exception
                    MsgBox("Error." + vbCrLf + ex.Message, vbOK)

                    Return
                End Try
            End If

            refresh()
            clear()
        End If
    End Sub

    Private Sub bttnAjustar_Click(sender As Object, e As EventArgs) Handles bttnAjustar.Click
        Form2.Show()
        Me.Enabled = False
    End Sub

    Sub adjust()
        Dim symbol As String = Form2.signo
        Dim condition As String = Form2.condition
        Dim confirm As Boolean = Form2.confirm
        Dim porcentage As Single = Val(Form2.txt.Text.Trim)
        Dim multiply As String = Form2.txt.Text.Trim

        Dim comando As String

        If confirm And porcentage > 0 Then
            Try
                comando = "UPDATE Client" + vbCrLf +
                    "SET Descubierto = Descubierto " + symbol + " (Descubierto * " +
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class
