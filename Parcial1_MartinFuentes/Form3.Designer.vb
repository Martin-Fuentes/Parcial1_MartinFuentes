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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tecnología al por mayor"
        '
        'tablaProduc
        '
        Me.tablaProduc.AllowUserToAddRows = False
        Me.tablaProduc.AllowUserToDeleteRows = False
        Me.tablaProduc.AllowUserToResizeColumns = False
        Me.tablaProduc.AllowUserToResizeRows = False
        Me.tablaProduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tablaProduc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.tablaProduc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.tablaProduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaProduc.Location = New System.Drawing.Point(27, 73)
        Me.tablaProduc.Name = "tablaProduc"
        Me.tablaProduc.ReadOnly = True
        Me.tablaProduc.Size = New System.Drawing.Size(727, 180)
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
        Me.tablaAnadido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.tablaAnadido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAnadido.Location = New System.Drawing.Point(27, 338)
        Me.tablaAnadido.Name = "tablaAnadido"
        Me.tablaAnadido.ReadOnly = True
        Me.tablaAnadido.Size = New System.Drawing.Size(727, 196)
        Me.tablaAnadido.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(357, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 73)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(799, 349)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(54, 54)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.Transparent
        Me.btnComprar.Enabled = False
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Location = New System.Drawing.Point(799, 479)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(54, 55)
        Me.btnComprar.TabIndex = 6
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'tot
        '
        Me.tot.AutoSize = True
        Me.tot.BackColor = System.Drawing.Color.Transparent
        Me.tot.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot.ForeColor = System.Drawing.Color.White
        Me.tot.Location = New System.Drawing.Point(491, 552)
        Me.tot.Name = "tot"
        Me.tot.Size = New System.Drawing.Size(0, 35)
        Me.tot.TabIndex = 7
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(799, 409)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(54, 54)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(875, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 93)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 606)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.tot)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tablaAnadido)
        Me.Controls.Add(Me.tablaProduc)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
