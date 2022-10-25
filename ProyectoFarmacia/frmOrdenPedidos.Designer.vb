<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenPedidos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbNumeroPedido = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbNombreCliente = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FARMACIA JMG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ofrece atención Profesional"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbNumeroPedido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 66)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cbNumeroPedido
        '
        Me.cbNumeroPedido.FormattingEnabled = True
        Me.cbNumeroPedido.Location = New System.Drawing.Point(9, 34)
        Me.cbNumeroPedido.Name = "cbNumeroPedido"
        Me.cbNumeroPedido.Size = New System.Drawing.Size(87, 21)
        Me.cbNumeroPedido.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Numero Pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "La Mejor Calidad en Medicamentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbNombreCliente)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.cbProducto)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtApellidos)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 205)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'cbNombreCliente
        '
        Me.cbNombreCliente.FormattingEnabled = True
        Me.cbNombreCliente.Location = New System.Drawing.Point(95, 16)
        Me.cbNombreCliente.Name = "cbNombreCliente"
        Me.cbNombreCliente.Size = New System.Drawing.Size(218, 21)
        Me.cbNombreCliente.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(95, 149)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(218, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(231, 123)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(82, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(95, 123)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(59, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(95, 95)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(218, 21)
        Me.cbProducto.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(95, 68)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(218, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(95, 42)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(218, 20)
        Me.txtApellidos.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Apellidos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre cliente:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(333, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(132, 32)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(333, 164)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 32)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(333, 53)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(132, 32)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(333, 127)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(132, 32)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(333, 90)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 32)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToResizeColumns = False
        Me.dgvPedidos.AllowUserToResizeRows = False
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPedidos.Location = New System.Drawing.Point(12, 371)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.Size = New System.Drawing.Size(471, 134)
        Me.dgvPedidos.TabIndex = 5
        Me.dgvPedidos.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(79, 511)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 32)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(217, 511)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 32)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(406, 517)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(69, 20)
        Me.txtTotal.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(364, 520)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Total:"
        '
        'frmOrdenPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(495, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrdenPedidos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbNumeroPedido As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbNombreCliente As ComboBox
End Class
