Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class Form1
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Public con As conexion
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New conexion()
        cmd = New MySqlCommand("Select * from cliente", con.getConexion())
        reader = cmd.ExecuteReader()
        If (IsNothing(reader)) Then
            MsgBox("No se hizo la conexión", MsgBoxStyle.MsgBoxHelp, "Titulo")
        Else
            MsgBox("Conexión establecida", MsgBoxStyle.MsgBoxHelp, "Titulo")
        End If

    End Sub
End Class