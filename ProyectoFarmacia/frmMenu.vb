Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Public Class frmMenu

    Public ConexionString As String = "Server=;Database=FARMACIA;Trusted_Connection=True;"

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub


    Private m_ChildFormNumber As Integer

    Private Sub tSalir_Click(sender As Object, e As EventArgs) Handles tSalir.Click
        Me.Close()
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private timer As Timer

    Private Sub timer_Click(s As Object, eventarg As EventArgs)

        DirectCast(s, Timer).Stop()
        MessageBox.Show("Bienvenidos al Sistema de Farmacia", "Farmacia")

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer = New Timer()
        Timer.Interval = 1
        AddHandler Timer.Tick, AddressOf timer_Click
        Timer.Start()
    End Sub

    Private Sub frmMenu_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub

    Private Sub frmMenu_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim newMDIChild As New frmClientes()
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub medicamentos_Click(sender As Object, e As EventArgs) Handles medicamentos.Click
        Dim newMDIChild As New frmMedicamentos()
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub

    Private Sub tsmOrdenPedidos_Click(sender As Object, e As EventArgs) Handles tsmOrdenPedidos.Click
        Dim newMDIChild As New frmOrdenPedidos()
        newMDIChild.MdiParent = Me
        newMDIChild.Show()
    End Sub
End Class
