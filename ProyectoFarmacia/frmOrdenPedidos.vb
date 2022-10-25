Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices

Public Class frmOrdenPedidos
    Private Sub Limpiar()
        cbNombreCliente.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtDireccion.Text = String.Empty
        cbProducto.Text = String.Empty
        txtCantidad.Text = String.Empty
        txtPrecio.Text = String.Empty
        cbNumeroPedido.Text = String.Empty
    End Sub
    Private Sub ObtenerTotal()
        If txtCantidad.Text = String.Empty Or txtPrecio.Text = String.Empty Then
            txtTotal.Text = "0.00"
            Return
        End If
        txtTotal.Text = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text)
    End Sub
    Private Sub LlenarComboPedidos()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable()

        Dim query As String = String.Empty
        query &= "SELECT Codigo FROM PEDIDOS"

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
                    cbNumeroPedido.DataSource = dt
                    cbNumeroPedido.DisplayMember = dt.Columns(0).ColumnName
                    cbNumeroPedido.ValueMember = dt.Columns(0).ColumnName
                End With
                Try
                    conn.Open()
                Catch ex As Exception
                    MessageBox.Show("no se pudo obtener información", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    conn.Close()
                    da.Dispose()
                End Try

            End Using
        End Using
    End Sub
    Private Sub CargarPedidosGrid()
        Dim dt As New DataTable
        Using DBCon As New SqlConnection(frmMenu.ConexionString),
            DBCmd As New SqlCommand("SELECT Codigo NumeroPedido,NombreCliente,Apellidos,Direccion FROM PEDIDOS", DBCon)
            DBCon.Open()
            dt.Load(DBCmd.ExecuteReader)
        End Using
        dgvPedidos.DataSource = dt
    End Sub
    Private Sub LlenarComboProductos()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable()

        Dim query As String = String.Empty
        query &= "SELECT codigo,Descripcion FROM MEDICAMENTOS"

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
                    cbProducto.DataSource = dt
                    cbProducto.DisplayMember = dt.Columns(1).ColumnName
                    cbProducto.ValueMember = dt.Columns(1).ColumnName
                End With
                Try
                    conn.Open()
                Catch ex As Exception
                    MessageBox.Show("no se pudo obtener informacion", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    conn.Close()
                    da.Dispose()
                End Try

            End Using
        End Using

    End Sub
    Private Sub LlenarComboClientes()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable()

        Dim query As String = String.Empty
        query &= "SELECT codigo,Nombre FROM CLIENTES"

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
                    cbNombreCliente.DataSource = dt
                    cbNombreCliente.DisplayMember = dt.Columns(1).ColumnName
                    cbNombreCliente.ValueMember = dt.Columns(1).ColumnName
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
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As String = String.Empty
        query &= "SELECT Codigo,NombreCliente,Apellidos,Direccion,Producto,Cantidad,Precio FROM PEDIDOS WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbNumeroPedido.Text)
                    conn.Open()
                End With
                Try
                    Dim reader As SqlDataReader = comm.ExecuteReader()
                    If (reader.Read()) Then

                        cbNombreCliente.Text = reader("NombreCliente").ToString()
                        txtApellidos.Text = reader("Apellidos").ToString()
                        txtDireccion.Text = reader("Direccion").ToString()
                        cbProducto.Text = reader("Producto").ToString()
                        txtCantidad.Text = reader("Cantidad").ToString()
                        txtPrecio.Text = reader("Precio").ToString()
                        CargarPedidosGrid()
                    Else
                        Me.Limpiar()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("No se encontro el pedido", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub frmOrdenPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboProductos()
        LlenarComboClientes()
        LlenarComboPedidos()
        CargarPedidosGrid()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> ","c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf(","c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cbNumeroPedido.Text = "" Then
            MessageBox.Show("Pedido no cargado favor de cargar a un pedido", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim Result As DialogResult = MessageBox.Show("¿Desea borrar el Pedido seleccionado?", "Eliminar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.No Then
            Return
        End If

        Dim query As String = String.Empty
        query &= "DELETE FROM PEDIDOS WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbNumeroPedido.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Cliente no borrado, favor de verificar", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    MessageBox.Show("Cliente borrado correctamente", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarComboPedidos()
                Catch ex As Exception
                    MessageBox.Show("Cliente no borrado favor de revisar la información capturada", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cbNombreCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreCliente.SelectedIndexChanged
        Dim query As String = String.Empty
        query &= "SELECT Apellidos,Direccion FROM CLIENTES WHERE Nombre=@Nombre"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Nombre", cbNombreCliente.Text)
                    conn.Open()
                End With
                Try
                    Dim reader As SqlDataReader = comm.ExecuteReader()
                    If (reader.Read()) Then
                        txtApellidos.Text = reader("Apellidos").ToString()
                        txtDireccion.Text = reader("Direccion").ToString()
                    Else
                        Me.Limpiar()
                    End If
                    reader.Close()
                Catch ex As Exception
                End Try
            End Using
        End Using
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCantidad.Text = String.Empty Or txtPrecio.Text = String.Empty Or cbProducto.Text = String.Empty Then
            MessageBox.Show("favor de capturar una todos los campos", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = String.Empty
        query &= "INSERT INTO PEDIDOS (NombreCliente,Apellidos,Direccion,Producto,Cantidad,Precio) "
        query &= "VALUES (@NombreCliente,@Apellidos,@Direccion,@Producto,@Cantidad,@Precio)"

        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@NombreCliente", cbNombreCliente.Text)
                    .Parameters.AddWithValue("@Apellidos", txtApellidos.Text)
                    .Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    .Parameters.AddWithValue("@Producto", cbProducto.Text)
                    .Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(txtCantidad.Text))
                    .Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text))
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Pedido no guardado favor de revisar la información capturada", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    MessageBox.Show("Pedido guardado correctamente", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarComboPedidos()
                    CargarPedidosGrid()
                Catch ex As Exception
                    MessageBox.Show("Pedido no guardado favor de revisar la información capturada", "Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dgvPedidos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellEnter

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        ObtenerTotal()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        ObtenerTotal()
    End Sub

    Private Sub dgvPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        If dgvPedidos.Rows.Count > 0 Then
            Me.cbNumeroPedido.Text = dgvPedidos.Rows(e.RowIndex).Cells(0).Value.ToString()
            btnBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Dim query As String = String.Empty
        query &= "SELECT PrecioUnidad FROM MEDICAMENTOS WHERE Descripcion=@Descripcion"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Descripcion", cbProducto.Text)
                    conn.Open()
                End With
                Try
                    Dim reader As SqlDataReader = comm.ExecuteReader()
                    If (reader.Read()) Then
                        txtPrecio.Text = reader("PrecioUnidad").ToString()
                    End If

                    reader.Close()
                Catch ex As Exception
                End Try
            End Using
        End Using
    End Sub
End Class