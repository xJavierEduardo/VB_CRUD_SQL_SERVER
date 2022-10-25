Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Windows

Public Class frmLogin
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If txtUsuario.Text = String.Empty Or txtClave.Text = String.Empty Then
            Return
        End If
        Dim query As String = String.Empty
        query &= "IF EXISTS(SELECT 1 FROM USUARIOS WHERE Usuario=@Usuario AND Clave=@Clave) SELECT 1 ELSE SELECT 0"
        Using conn As New SqlConnection(frmMenu.ConexionString)
            Using comm As New SqlCommand()
                With comm

                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                    .Parameters.AddWithValue("@Clave", txtClave.Text)
                    conn.Open()
                End With
                Try
                    If Convert.ToInt16(comm.ExecuteScalar()) = 0 Then
                        MessageBox.Show("Usuario o contraseña incorrecto, favor de verificar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se encontró el usuario seleccionado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using

        Dim form As New frmMenu()
        form.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
