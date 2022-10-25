Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class frmMedicamentos
    Private CodigoMedicamento As String = ""
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        cbCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtPU.Text = String.Empty
        txtPC.Text = String.Empty
        dtpVencimiento.Value = DateTime.Now
        txtStock.Text = String.Empty
        txtCodigoCat.Text = String.Empty
        CodigoMedicamento = ""
    End Sub
    Private Sub LlenarCombo()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        Dim dt As DataTable = New DataTable()

        Dim query As String = String.Empty
        query &= "SELECT Codigo FROM MEDICAMENTOS"

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
                    MessageBox.Show("no se pudo obtener información", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    conn.Close()
                    da.Dispose()
                End Try

            End Using
        End Using

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cbCodigo.Items.Count = 0 Then
            Return
        End If
        CodigoMedicamento = cbCodigo.Text
        Dim query As String = String.Empty
        query &= "SELECT Descripcion,PrecioUnidad,PrecioCompra,FechaVencimiento,Stock,CodigoCategoria FROM MEDICAMENTOS WHERE Codigo=@Codigo"
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
                    If (reader.Read()) Then
                        txtDescripcion.Text = reader("Descripcion").ToString()
                        txtPU.Text = reader("PrecioUnidad").ToString()
                        txtPC.Text = reader("PrecioCompra").ToString()
                        dtpVencimiento.Value = Convert.ToDateTime(reader("FechaVencimiento"))
                        txtStock.Text = reader("Stock").ToString()
                        txtCodigoCat.Text = reader("CodigoCategoria").ToString()
                    Else
                        MessageBox.Show("No se encontro el medicamento seleccionado", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Limpiar()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("No se encontro el medicamento seleccionado", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO Medicamentos (Codigo,Descripcion,PrecioUnidad,PrecioCompra,FechaVencimiento,Stock,CodigoCategoria) "
        query &= "VALUES (@Codigo,@Descripcion,@PrecioUnidad,@PrecioCompra,@FechaVencimiento,@Stock,@CodigoCategoria)"

        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", cbCodigo.Text)
                    .Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    .Parameters.AddWithValue("@PrecioUnidad", txtPU.Text)
                    .Parameters.AddWithValue("@PrecioCompra", txtPC.Text)
                    .Parameters.AddWithValue("@FechaVencimiento", dtpVencimiento.Value)
                    .Parameters.AddWithValue("@Stock", txtStock.Text)
                    .Parameters.AddWithValue("@CodigoCategoria", txtCodigoCat.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Medicamento no guardado favor de revisar la información capturada", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    MessageBox.Show("Medicamento guardado correctamente", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Medicamento no guardado favor de revisar la información capturada", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub txtPU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPU.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> ","c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf(","c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPC.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> ","c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf(","c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombo()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cbCodigo.Text = "" Or CodigoMedicamento = "" Then
            MessageBox.Show("Medicamento no seleccionado, favor de cargar a un codigo valido", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = String.Empty
        query &= "UPDATE MEDICAMENTOS SET Codigo=@NuevoCodigo,Descripcion=@Descripcion,PrecioUnidad=@PrecioUnidad,PrecioCompra=@PrecioCompra,FechaVencimiento=@FechaVencimiento,Stock=@Stock,CodigoCategoria=@CodigoCategoria WHERE CODIGO=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", CodigoMedicamento)
                    .Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    .Parameters.AddWithValue("@PrecioUnidad", txtPU.Text)
                    .Parameters.AddWithValue("@PrecioCompra", txtPC.Text)
                    .Parameters.AddWithValue("@FechaVencimiento", dtpVencimiento.Value)
                    .Parameters.AddWithValue("@Stock", txtStock.Text)
                    .Parameters.AddWithValue("@CodigoCategoria", txtCodigoCat.Text)
                    .Parameters.AddWithValue("@NuevoCodigo", cbCodigo.Text)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Medicamento no guardado, favor de verificar", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    MessageBox.Show("Medicamento guardado correctamente", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Medicamento no guardado favor de revisar la información capturada", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If CodigoMedicamento = "" Then
            MessageBox.Show("Medicamento no cargado favor de cargar a un medicamento", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Result As DialogResult = MessageBox.Show("¿Desea borrar el medicamento seleccionado?", "Eliminar medicamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.No Then
            Return
        End If

        Dim query As String = String.Empty
        query &= "DELETE FROM MEDICAMENTOS WHERE Codigo=@Codigo"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Codigo", CodigoMedicamento)
                End With
                Try
                    conn.Open()
                    If Convert.ToInt16(comm.ExecuteNonQuery()) = 0 Then
                        MessageBox.Show("Medicamento no borrado, favor de verificar", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    MessageBox.Show("Medicamento borrado correctamente", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    LlenarCombo()
                Catch ex As Exception
                    MessageBox.Show("Medicamento no borrado favor de revisar la información capturada", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBusquedaA_Click(sender As Object, e As EventArgs) Handles btnBusquedaA.Click
        Dim dt As New DataTable
        Using DBCon As New SqlConnection(frmMenu.ConexionString),
            DBCmd As New SqlCommand("SELECT * FROM MEDICAMENTOS WHERE DESCRIPCION LIKE '%" + txtBusquedaCliente.Text + "%'", DBCon)
            DBCon.Open()
            dt.Load(DBCmd.ExecuteReader)
        End Using
        DataGridView1.DataSource = dt
        DataGridView1.AutoResizeColumns()
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

    Private Sub btnSalirForm_Click(sender As Object, e As EventArgs) Handles btnSalirForm.Click
        Me.Close()
    End Sub
End Class