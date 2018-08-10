Public Class SiguienteForm
    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Dim a As MainForm = Me.Parent.Parent
        a._Siguiente("C")
    End Sub

    Private Sub btnSiguienteVentas_Click(sender As Object, e As EventArgs) Handles btnSiguienteVentas.Click
        Dim a As MainForm = Me.Parent.Parent
        a._Siguiente("V")
    End Sub

    Private Sub btnSiguienteServicio_Click(sender As Object, e As EventArgs) Handles btnSiguienteServicio.Click
        Dim a As MainForm = Me.Parent.Parent
        a._Siguiente("S")
    End Sub
End Class