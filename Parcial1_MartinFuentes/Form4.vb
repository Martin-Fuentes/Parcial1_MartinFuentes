Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Diagnostics.Eventing
Imports System.Drawing

Public Class Form4
    Public id As String
    Public tabla As DataTable
    Public con As conexion
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public ced As String
    Public Sub New(id_com As Integer, cedula As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim pre_tot As Double = 0
        id = id_com
        ced = cedula
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        con = New conexion()
        cmd = New MySqlCommand("Select producto.id_producto as 'ID', nombre as 'Artículo', marca as 'Marca', precio as 'Precio',compra_producto.cantidad as 'Cantidad',ROUND((precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'ITBMS', ROUND((precio*compra_producto.cantidad)+(precio*compra_producto.cantidad)*compra_producto.itbms,2) as 'Total Artículo' from producto, compra_producto WHERE producto.id_producto=compra_producto.id_producto And compra_producto.id_compra=" & id_com, con.getConexion())
        reader = cmd.ExecuteReader()
        tabla = New DataTable()
        tabla.Load(reader)
        tablaCompra.DataSource = tabla
        reader.Close()
        con = New conexion()
        cmd = New MySqlCommand("Select SUM((pro.precio*com.cantidad*com.itbms)+pro.precio*com.cantidad) from producto as pro, compra_producto as com WHERE com.id_producto=pro.id_producto And com.id_compra=" & id, con.getConexion)
        reader = cmd.ExecuteReader()
        reader.Read()

        pre_tot = reader.Item(0)
        tota.Text = "Tu compra: " & Format(pre_tot, "f")

        reader.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim frm As New Form3(id, ced)
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim frm As New Form1()
        frm.Show()
    End Sub
End Class