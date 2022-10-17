Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class Form1
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Public con As conexion
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Dim frm As New Form2()
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try '
            If (txtUsu.Text.Length > 0 And txtContra.Text.Length > 0) Then
                con = New conexion()
                cmd = New MySqlCommand("Select rol,cedula from usuario where usuario='" & txtUsu.Text & "' AND contrasena='" & txtContra.Text & "'", con.getConexion())
                reader = cmd.ExecuteReader()

                If (reader.Read() = Nothing) Then
                    MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Information, "Error")
                Else

                    Me.Hide()
                    Dim frm As New Form3(-1, reader.Item(1))
                    frm.Show()

                End If
                reader.Close()
            Else
                MsgBox("Por favor, complete los campos", MsgBoxStyle.Information, "Titulo")

            End If

        Catch ex As Exception '
            MsgBox(ex.Message, MsgBoxStyle.Information, "Titulo") '
        End Try '
    End Sub
End Class