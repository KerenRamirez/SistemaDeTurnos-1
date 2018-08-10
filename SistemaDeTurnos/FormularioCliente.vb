Public Class FormularioCliente
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroIdentidad.TextChanged

    End Sub

    Private Sub nuevoClienteButton_Click(sender As Object, e As EventArgs) Handles nuevoClienteButton.Click
        Dim a As MainForm = Me.Parent.Parent
        Dim identidad = txtNumeroIdentidad.Text
        txtNumeroIdentidad.Text = ""
        If radioButtonCaja.Checked Then
            a._AgregarCliente(identidad, "C")
        End If

        If radioButtonServicio.Checked Then
            a._AgregarCliente(identidad, "S")
        End If

        If radioButtonVentas.Checked Then
            a._AgregarCliente(identidad, "V")
        End If


        Dim b = 0
    End Sub
End Class