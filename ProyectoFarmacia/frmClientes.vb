Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class frmClientes
    Private ClienteCargado As Boolean = False
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        Me.txtNombre.Text = String.Empty
        Me.txtApellido.Text = String.Empty
        Me.txtDireccion.Text = String.Empty
        Me.txtCelular.Text = String.Empty
        Me.cbSexo.SelectedIndex = 0
        Me.ClienteCargado = False
    End Sub
    Private Sub LlenarCombo()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable()

        Dim query As String = String.Empty
        query &= "SELECT Codigo FROM CLIENTES"

        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                End With
                With da
                    .SelectCommand = comm
                    .Fill(dt)
                    cbCodigo.DataSource = dt
                    cbCodigo.DisplayMember = dt.Columns(0).ColumnName
                    cbCodigo.ValueMember = dt.Columns(0).ColumnName
                End With
                Try
                    conn.Open()
                Catch ex As Exception
                    MessageBox.Show("no se pudo obtener informacion", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    conn.Close()
                    da.Dispose()
                End Try

            End Using
        End Using

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO CLIENTES (Nombre,Apellidos,Direccion,Celular,Sexo) "
        query &= "VALUES (@Nombre,@Apellidos,@Direccion,@Celular,@Sexo)"

        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    .Parameters.AddWithValue("@Apellidos", txtApellido.Text)
                    .Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    .Parameters.AddWithValue("@Celular", txtCelular.Text)
                    .Parameters.AddWithValue("@Sexo", cbSexo.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Cliente no guardado favor de revisar la información capturada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    MessageBox.Show("Cliente guardado correctamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Cliente no guardado favor de revisar la información capturada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim Result As DialogResult = MessageBox.Show("¿Desea limpiar la pantalla?", "Limpiar pantalla", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.No Then
            Return
        End If
        Me.Limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cbCodigo.Text = "" Or ClienteCargado = False Then
            MessageBox.Show("Cliente no cargado favor de cargar a un cliente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim Result As DialogResult = MessageBox.Show("¿Desea borrar el cliente seleccionado?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.No Then
            Return
        End If

        Dim query As String = String.Empty
        query &= "DELETE FROM CLIENTES WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbCodigo.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Cliente no borrado, favor de verificar", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    MessageBox.Show("Cliente borrado correctamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Cliente no borrado favor de revisar la información capturada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombo()
        If cbCodigo.Items.Count > 0 Then
            btnBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = String.Empty
        query &= "SELECT Nombre,Apellidos,Direccion,Celular,Sexo FROM CLIENTES WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbCodigo.Text)
                    conn.Open()
                End With
                Try
                    Dim reader As SqlDataReader = comm.ExecuteReader()
                    While (reader.Read())
                        ClienteCargado = True
                        txtNombre.Text = reader("Nombre").ToString()
                        txtApellido.Text = reader("Apellidos").ToString()
                        txtDireccion.Text = reader("Direccion").ToString()
                        txtCelular.Text = reader("Celular").ToString()
                        cbSexo.SelectedItem = reader("Sexo").ToString()
                    End While
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("No se encontro cliente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cbCodigo.Text = "" Or ClienteCargado = False Then
            MessageBox.Show("Cliente no cargado favor de cargar a un cliente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = String.Empty
        query &= "UPDATE CLIENTES SET Nombre=@Nombre,Apellidos=@Apellidos,Direccion=@Direccion,Celular=@Celular,Sexo=@Sexo WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbCodigo.Text)
                    .Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    .Parameters.AddWithValue("@Apellidos", txtApellido.Text)
                    .Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    .Parameters.AddWithValue("@Celular", txtCelular.Text)
                    .Parameters.AddWithValue("@Sexo", cbSexo.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Cliente no guardado, favor de verificar", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    MessageBox.Show("Cliente guardado correctamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Cliente no guardado favor de revisar la información capturada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnBusquedaA_Click(sender As Object, e As EventArgs) Handles btnBusquedaA.Click
        Dim dt As New DataTable
        Using DBCon As New SqlConnection(frmMenu.ConexionString),
            DBCmd As New SqlCommand("SELECT * FROM CLIENTES WHERE NOMBRE LIKE '%" + txtBusquedaCliente.Text + "%'", DBCon)
            DBCon.Open()
            dt.Load(DBCmd.ExecuteReader)
        End Using
        DataGridView1.DataSource = dt
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        SendKeys.SendWait("%{PRTSC}")
        Dim pantalla As Bitmap
        pantalla = (CType((Clipboard.GetDataObject().GetData("Bitmap")), Bitmap))
        Dim objSFD As New SaveFileDialog
        objSFD.Filter = "JPEG/*.jpg|"
        objSFD.InitialDirectory = "C:\"
        If objSFD.ShowDialog() = DialogResult.OK Then
            pantalla.Save(objSFD.FileName & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub cbCodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCodigo.SelectedIndexChanged
        Me.Limpiar()
    End Sub
End Class