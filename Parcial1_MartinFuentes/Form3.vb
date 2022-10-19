Imports System.Data
Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports Google.Protobuf.WellKnownTypes
Imports System.Threading
Imports Org.BouncyCastle.Utilities

Public Class Form3
    Public tabla As DataTable
    Public con As conexion
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public ced As String
    Public cont As Integer = 0
    Public id_com As Integer = 0
    Public pre_tot As Double = 0
    Public contad2 = 0
    Public Sub New(sask As Integer, cedula As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.ced = cedula
        con = New conexion()
        cmd = New MySqlCommand("Select id_producto as 'ID', nombre as 'Artículo', marca as 'Marca', precio as 'Precio' from producto", con.getConexion())
        reader = cmd.ExecuteReader()

        tabla = New DataTable()
        tabla.Load(reader)


        tablaProduc.DataSource = tabla
        con = New conexion()
        cmd = New MySqlCommand("Select Max(id_compra) from compra", con.getConexion)

        reader = cmd.ExecuteReader()
        reader.Read()

        Try
            id_com = reader.Item(0) + 1

        Catch
            id_com = 1
        End Try
        Dim fechaActual As Date = Date.Now
        reader.Close()
        con = New conexion()
        cmd = New MySqlCommand("Insert Into compra (id_compra,cedula, fecha, total) values (@id,@cedula,@fecha,@tot)", con.getConexion())
        cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id_com
        cmd.Parameters.Add("@cedula", MySqlDbType.VarChar).Value = ced
        cmd.Parameters.Add("@fecha", MySqlDbType.Date).Value = fechaActual
        cmd.Parameters.Add("@tot", MySqlDbType.Decimal).Value = 0

        cmd.ExecuteNonQuery()



        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cant As Integer = 0
        Dim itmbs = 0.07
        Try
            Do
                Cant = InputBox("Ingrese la cantidad del producto", "Insertar", "Ingrese cantidad")
                If (Cant <= 0) Then
                    MsgBox("Error, la cantidad debe ser mayor a cero", MsgBoxStyle.Information, "Error")
                End If
            Loop While Cant <= 0
            Dim id = tablaProduc.CurrentRow.Cells("ID").Value


            Try
                con = New conexion()
                cmd = New MySqlCommand("Select cantidad from compra_producto WHERE id_producto = @id_p and id_compra = @id_c", con.getConexion)
                cmd.Parameters.Add("@id_p", MySqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
                reader = cmd.ExecuteReader()
                reader.Read()
                Dim cantidad As Integer = reader.Item(0)


                reader.Close()
                Dim cantP = cantidad + Cant
                con = New conexion()
                cmd = New MySqlCommand("UPDATE compra_producto set cantidad = @cant  WHERE id_producto = @id_p and id_compra = @id_c;", con.getConexion())
                cmd.Parameters.Add("@cant", MySqlDbType.Int64).Value = cantP
                cmd.Parameters.Add("@id_p", MySqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
                Dim ks = cmd.ExecuteNonQuery()

            Catch ex As Exception
                con = New conexion()
                cmd = New MySqlCommand("Insert Into compra_producto (id_producto,id_compra,cantidad, itbms) values (@pro,@com,@cant,@itbms)", con.getConexion())
                cmd.Parameters.Add("@pro", MySqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@cant", MySqlDbType.UInt64).Value = Cant
                cmd.Parameters.Add("@com", MySqlDbType.VarChar).Value = id_com
                cmd.Parameters.Add("@itbms", MySqlDbType.Decimal).Value = itmbs
                cmd.ExecuteNonQuery()
                btnComprar.Enabled = True
                btnEliminar.Enabled = True
                btnModificar.Enabled = True
                contad2 += 1


            End Try



            con = New conexion()
            cmd = New MySqlCommand("Select producto.id_producto as 'ID', nombre as 'Artículo', marca as 'Marca', precio as 'Precio',compra_producto.cantidad as 'Cantidad',ROUND((precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'ITBMS', ROUND((precio*compra_producto.cantidad)+(precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'Total Artículo' from producto, compra_producto WHERE producto.id_producto=compra_producto.id_producto And compra_producto.id_compra=" & id_com, con.getConexion())
            reader = cmd.ExecuteReader()
            tabla = New DataTable()
            tabla.Load(reader)
            tablaAnadido.DataSource = tabla
            reader.Close()

            con = New conexion()
            cmd = New MySqlCommand("Select SUM((pro.precio*com.cantidad*com.itbms)+pro.precio*com.cantidad) from producto as pro, compra_producto as com WHERE com.id_producto=pro.id_producto And com.id_compra=" & id_com, con.getConexion)
            reader = cmd.ExecuteReader()
            reader.Read()
            pre_tot = reader.Item(0)
            tot.Text = "Tu compra: " & Format(pre_tot, "f")
            con = New conexion()
            cmd = New MySqlCommand("Update compra set total = @tot where id_compra = @id", con.getConexion())
            cmd.Parameters.Add("@tot", MySqlDbType.Decimal).Value = pre_tot
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id_com
            cmd.ExecuteNonQuery()


        Catch
            MsgBox("No se añadió nada porque no ingresó la cantidad", MsgBoxStyle.Information, "Error")

        End Try


    End Sub
    Dim contad = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If MessageBox.Show("¿Desea comprar estos artículos?", "Comprar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con = New conexion()
            cmd = New MySqlCommand("Update compra set total = @tot where id_compra = @id", con.getConexion())
            cmd.Parameters.Add("@tot", MySqlDbType.Decimal).Value = pre_tot
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id_com
            cmd.ExecuteNonQuery()
            contad += 1
            Me.Close()
            Dim frm As New Form4(id_com, ced)
            frm.Show()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id = tablaAnadido.CurrentRow.Cells("ID").Value
        Dim art = tablaAnadido.CurrentRow.Cells("Artículo").Value
        If MessageBox.Show("¿Desea Eliminar " & art & " de los artículos a comprar?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con = New conexion()
            cmd = New MySqlCommand("Delete from compra_producto where id_producto = @id_p and id_compra = @id_c", con.getConexion())
            cmd.Parameters.Add("@id_p", MySqlDbType.VarChar).Value = id
            cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
            cmd.ExecuteNonQuery()

            con = New conexion()
            cmd = New MySqlCommand("Select producto.id_producto as 'ID', nombre as 'Artículo', marca as 'Marca', precio as 'Precio',compra_producto.cantidad as 'Cantidad',ROUND((precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'ITBMS', ROUND((precio*compra_producto.cantidad)+(precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'Total Artículo' from producto, compra_producto WHERE producto.id_producto=compra_producto.id_producto And compra_producto.id_compra=" & id_com, con.getConexion())
            reader = cmd.ExecuteReader()
            tabla = New DataTable()
            tabla.Load(reader)
            tablaAnadido.DataSource = tabla
            reader.Close()

            con = New conexion()
            cmd = New MySqlCommand("Select SUM((pro.precio*com.cantidad*com.itbms)+pro.precio*com.cantidad) from producto as pro, compra_producto as com WHERE com.id_producto=pro.id_producto And com.id_compra=" & id_com, con.getConexion)
            reader = cmd.ExecuteReader()
            reader.Read()
            Try
                pre_tot = reader.Item(0)
                tot.Text = "Tu compra: " & Format(pre_tot, "f")
            Catch
                tot.Text = ""
                pre_tot = 0
                btnComprar.Enabled = False
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
                contad2 = 0
            End Try
            reader.Close()

            con = New conexion()
            cmd = New MySqlCommand("Update compra set total = @tot where id_compra = @id", con.getConexion())
            cmd.Parameters.Add("@tot", MySqlDbType.Decimal).Value = pre_tot
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id_com
            cmd.ExecuteNonQuery()
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Cant As Integer = 0

        Try
            Dim id = tablaAnadido.CurrentRow.Cells("ID").Value
            Dim proc = tablaAnadido.CurrentRow.Cells("Artículo").Value
            Do
                Cant = InputBox("Ingrese la cantidad de " & proc & " que desea llevar", "Insertar", "Ingrese cantidad")
                If (Cant <= 0) Then
                    MsgBox("Error, la cantidad debe ser mayor a cero", MsgBoxStyle.Information, "Error")
                End If
            Loop While Cant <= 0
            If MessageBox.Show("¿Desea Modificar la cantidad de " & proc & " a " & Cant & "?", "Modificar", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                con = New conexion()
                cmd = New MySqlCommand("Update compra_producto set cantidad = @cant where id_producto = @id_p and id_compra = @id_c", con.getConexion())
                cmd.Parameters.Add("@cant", MySqlDbType.Int64).Value = Cant
                cmd.Parameters.Add("@id_p", MySqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@id_c", MySqlDbType.VarChar).Value = id_com
                cmd.ExecuteNonQuery()
                con = New conexion()
                cmd = New MySqlCommand("Select producto.id_producto as 'ID', nombre as 'Artículo', marca as 'Marca', precio as 'Precio',compra_producto.cantidad as 'Cantidad',ROUND((precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'ITBMS', ROUND((precio*compra_producto.cantidad)+(precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'Total Artículo' from producto, compra_producto WHERE producto.id_producto=compra_producto.id_producto And compra_producto.id_compra=" & id_com, con.getConexion())
                reader = cmd.ExecuteReader()
                tabla = New DataTable()
                tabla.Load(reader)
                tablaAnadido.DataSource = tabla
                reader.Close()

                con = New conexion()
                cmd = New MySqlCommand("Select SUM((pro.precio*com.cantidad*com.itbms)+pro.precio*com.cantidad) from producto as pro, compra_producto as com WHERE com.id_producto=pro.id_producto And com.id_compra=" & id_com, con.getConexion)
                reader = cmd.ExecuteReader()
                reader.Read()
                pre_tot = reader.Item(0)
                tot.Text = "Tu compra: " & Format(pre_tot, "f")
                reader.Close()

                con = New conexion()
                cmd = New MySqlCommand("Update compra set total = @tot where id_compra = @id", con.getConexion())
                cmd.Parameters.Add("@tot", MySqlDbType.Decimal).Value = pre_tot
                cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id_com
                cmd.ExecuteNonQuery()
            End If


        Catch
            MsgBox("No se modificó porque no ingresó la cantidad", MsgBoxStyle.Information, "Error")
        End Try


    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (contad = 0 And contad2 > 0) Then
            If MessageBox.Show("¿Desea salir sin completar la compra?", "Cerrar el formulario", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                con = New conexion()
                cmd = New MySqlCommand("Delete from compra_producto where id_compra = @id_c", con.getConexion())
                cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
                cmd.ExecuteNonQuery()
                con = New conexion()
                cmd = New MySqlCommand("Delete from compra where id_compra = @id_c", con.getConexion())
                cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
                cmd.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (Not contad2 > 0) Then
            con = New conexion()
            cmd = New MySqlCommand("Delete from compra where id_compra = @id_c", con.getConexion())
            cmd.Parameters.Add("@id_c", MySqlDbType.Int64).Value = id_com
            cmd.ExecuteNonQuery()
            Me.Close()
            Dim frm As New Form1()
            frm.Show()
        Else
            Me.Close()
            Dim frm As New Form1()
            frm.Show()

        End If
    End Sub
End Class