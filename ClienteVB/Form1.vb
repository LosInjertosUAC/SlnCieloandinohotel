Public Class Form1
    Dim servicio As New UServicio.wsReservaSoapClient
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        servicio.Agregar(txtCodreserva.Text, txtCodcliente.Text, txtInicio.Text, txtFinal.Text, txtNropersonas.Text, txtObserbaciones.Text)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        servicio.Eliminar(txtCodreserva.Text)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        servicio = New UServicio.wsReservaSoapClient
        Dim texto As String = txtCodreserva.Text
        dgvReserva.DataSource = servicio.Listar.Tables(0)
    End Sub
End Class
