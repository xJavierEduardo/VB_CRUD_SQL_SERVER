<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(105, 6)
        Me.txtUsuario.MaxLength = 13
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(183, 35)
        Me.txtUsuario.TabIndex = 0
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(105, 48)
        Me.txtClave.MaxLength = 8
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(183, 35)
        Me.txtClave.TabIndex = 1
        Me.txtClave.UseSystemPasswordChar = True
        '
        'btnEntrar
        '
        Me.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEntrar.Image = CType(resources.GetObject("btnEntrar.Image"), System.Drawing.Image)
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.Location = New System.Drawing.Point(105, 89)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(91, 32)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(202, 89)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(86, 32)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(292, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 77)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(363, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
