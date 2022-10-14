Imports MySql.Data.MySqlClient

Public Class Form2
    Private cmd As MySqlCommand
    Private con As conexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtsexo As String
        If (txtCed.Text.Length <> 0 And txtNom.Text.Length <> 0 And txtDir.Text.Length <> 0 And comboSexo.SelectedIndex > -1 And Val(txtTel.Text) > 0 And txtCorreo.Text.Length <> 0 And txtUsu.Text.Length <> 0 And txtContra1.Text.Length <> 0 And txtContra2.Text.Length <> 0) Then
            If (comboSexo.SelectedIndex = 0) Then
                txtsexo = "M"
            Else
                txtsexo = "F"
            End If
            If (Val(txtTel.Text) >= 60000000 And Val(txtTel.Text) < 70000000) Then
                If (txtContra1.Text.Equals(txtContra2.Text)) Then
                    con = New conexion()
                    cmd = New MySqlCommand("Insert Into usuario (cedula, nombre, direccion,sexo, tel, correo, usuario, contrasena,rol) values (@ced,@nom,@dir,@sexo,@tel,@correo,@user,@pass,@rol)", con.getConexion())
                    cmd.Parameters.Add("@ced", MySqlDbType.VarChar).Value = txtCed.Text
                    cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = txtNom.Text
                    cmd.Parameters.Add("@dir", MySqlDbType.VarChar).Value = txtDir.Text
                    cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = txtsexo
                    cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = Val(txtTel.Text)
                    cmd.Parameters.Add("@correo", MySqlDbType.VarChar).Value = txtCorreo.Text
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsu.Text
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtContra2.Text
                    cmd.Parameters.Add("@rol", MySqlDbType.VarChar).Value = "Cliente"
                    cmd.ExecuteNonQuery()
                    MsgBox("SE HA CREADO SU CUENTA SATISFACTORIAMENTE", MsgBoxStyle.MsgBoxHelp, "Error")
                    Me.Close()
                    Dim frm As New Form1()
                    frm.Show()
                Else
                    MsgBox("La segunda contraseña no coincide", MsgBoxStyle.MsgBoxHelp, "Error")

                End If
            Else
                MsgBox("Formato de téléfono incorrecta", MsgBoxStyle.MsgBoxHelp, "Error")
            End If
        Else
            MsgBox("Faltan campos por llenar", MsgBoxStyle.MsgBoxHelp, "Error")
        End If

    End Sub
End Class