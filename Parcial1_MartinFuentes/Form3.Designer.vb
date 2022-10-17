<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaProduc = New System.Windows.Forms.DataGridView()
        Me.tablaAnadido = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.tot = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.tablaProduc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaAnadido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'tablaProduc
        '
        Me.tablaProduc.AllowUserToAddRows = False
        Me.tablaProduc.AllowUserToDeleteRows = False
        Me.tablaProduc.AllowUserToResizeColumns = False
        Me.tablaProduc.AllowUserToResizeRows = False
        Me.tablaProduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablaProduc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.tablaProduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaProduc.Location = New System.Drawing.Point(27, 73)
        Me.tablaProduc.Name = "tablaProduc"
        Me.tablaProduc.ReadOnly = True
        Me.tablaProduc.Size = New System.Drawing.Size(727, 170)
        Me.tablaProduc.TabIndex = 1
        '
        'tablaAnadido
        '
        Me.tablaAnadido.AllowUserToAddRows = False
        Me.tablaAnadido.AllowUserToDeleteRows = False
        Me.tablaAnadido.AllowUserToResizeColumns = False
        Me.tablaAnadido.AllowUserToResizeRows = False
        Me.tablaAnadido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablaAnadido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.tablaAnadido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAnadido.Location = New System.Drawing.Point(27, 313)
        Me.tablaAnadido.Name = "tablaAnadido"
        Me.tablaAnadido.ReadOnly = True
        Me.tablaAnadido.Size = New System.Drawing.Size(727, 170)
        Me.tablaAnadido.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "AÑADIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(821, 220)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.Enabled = False
        Me.btnComprar.Location = New System.Drawing.Point(820, 313)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 6
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'tot
        '
        Me.tot.AutoSize = True
        Me.tot.Location = New System.Drawing.Point(838, 385)
        Me.tot.Name = "tot"
        Me.tot.Size = New System.Drawing.Size(0, 13)
        Me.tot.TabIndex = 7
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(821, 267)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(869, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cerrar Sesión"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 546)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.tot)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tablaAnadido)
        Me.Controls.Add(Me.tablaProduc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.tablaProduc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaAnadido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents tablaAnadido As Windows.Forms.DataGridView
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents btnEliminar As Windows.Forms.Button
    Friend WithEvents btnComprar As Windows.Forms.Button
    Friend WithEvents tot As Windows.Forms.Label
    Friend WithEvents tablaProduc As Windows.Forms.DataGridView
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
