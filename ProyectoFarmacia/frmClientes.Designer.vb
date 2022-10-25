<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.tcClientes = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cbCodigo = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBusquedaA = New System.Windows.Forms.Button()
        Me.txtBusquedaCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tcClientes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcClientes
        '
        Me.tcClientes.Controls.Add(Me.TabPage1)
        Me.tcClientes.Controls.Add(Me.TabPage2)
        Me.tcClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcClientes.Location = New System.Drawing.Point(0, 0)
        Me.tcClientes.Name = "tcClientes"
        Me.tcClientes.SelectedIndex = 0
        Me.tcClientes.Size = New System.Drawing.Size(683, 292)
        Me.tcClientes.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.txtCelular)
        Me.TabPage1.Controls.Add(Me.btnSalir)
        Me.TabPage1.Controls.Add(Me.txtDireccion)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.txtApellido)
        Me.TabPage1.Controls.Add(Me.btnImprimir)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.cbSexo)
        Me.TabPage1.Controls.Add(Me.btnLimpiar)
        Me.TabPage1.Controls.Add(Me.cbCodigo)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(535, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(132, 32)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(90, 126)
        Me.txtCelular.MaxLength = 10
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(167, 20)
        Me.txtCelular.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(535, 228)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 32)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(90, 96)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(392, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(535, 43)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 32)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(90, 65)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(392, 20)
        Me.txtApellido.TabIndex = 2
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(535, 191)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 32)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(392, 20)
        Me.txtNombre.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(535, 80)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(132, 32)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"masculino", "femenino"})
        Me.cbSexo.Location = New System.Drawing.Point(90, 154)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(121, 21)
        Me.cbSexo.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(535, 154)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(132, 32)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cbCodigo
        '
        Me.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCodigo.FormattingEnabled = True
        Me.cbCodigo.Location = New System.Drawing.Point(90, 6)
        Me.cbCodigo.Name = "cbCodigo"
        Me.cbCodigo.Size = New System.Drawing.Size(121, 21)
        Me.cbCodigo.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(535, 117)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 32)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Celular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Sexo:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnBusquedaA)
        Me.TabPage2.Controls.Add(Me.txtBusquedaCliente)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(675, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Búsqueda Avanzada"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(594, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBusquedaA
        '
        Me.btnBusquedaA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBusquedaA.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusquedaA.Image = CType(resources.GetObject("btnBusquedaA.Image"), System.Drawing.Image)
        Me.btnBusquedaA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusquedaA.Location = New System.Drawing.Point(594, 3)
        Me.btnBusquedaA.Name = "btnBusquedaA"
        Me.btnBusquedaA.Size = New System.Drawing.Size(73, 32)
        Me.btnBusquedaA.TabIndex = 1
        Me.btnBusquedaA.Text = "Buscar"
        Me.btnBusquedaA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBusquedaA.UseVisualStyleBackColor = False
        '
        'txtBusquedaCliente
        '
        Me.txtBusquedaCliente.Location = New System.Drawing.Point(88, 10)
        Me.txtBusquedaCliente.Name = "txtBusquedaCliente"
        Me.txtBusquedaCliente.Size = New System.Drawing.Size(500, 20)
        Me.txtBusquedaCliente.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Nombre:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(661, 166)
        Me.DataGridView1.TabIndex = 0
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcClientes)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.tcClientes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcClientes As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbCodigo As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBusquedaA As Button
    Friend WithEvents txtBusquedaCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
