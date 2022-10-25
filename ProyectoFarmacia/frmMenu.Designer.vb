<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.btnClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.medicamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOrdenPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClientes, Me.medicamentos, Me.tsmOrdenPedidos, Me.tSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1170, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'btnClientes
        '
        Me.btnClientes.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(61, 20)
        Me.btnClientes.Text = "Clientes"
        '
        'medicamentos
        '
        Me.medicamentos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.medicamentos.Name = "medicamentos"
        Me.medicamentos.Size = New System.Drawing.Size(98, 20)
        Me.medicamentos.Text = "Medicamentos"
        '
        'tsmOrdenPedidos
        '
        Me.tsmOrdenPedidos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.tsmOrdenPedidos.Name = "tsmOrdenPedidos"
        Me.tsmOrdenPedidos.Size = New System.Drawing.Size(113, 20)
        Me.tsmOrdenPedidos.Text = "Orden de pedidos"
        '
        'tSalir
        '
        Me.tSalir.Name = "tSalir"
        Me.tSalir.Size = New System.Drawing.Size(41, 20)
        Me.tSalir.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farmacia Menu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents medicamentos As ToolStripMenuItem
    Friend WithEvents tsmOrdenPedidos As ToolStripMenuItem
End Class
