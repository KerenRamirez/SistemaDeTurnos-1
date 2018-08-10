Public Class FormListas
    Dim countCaja = 0
    Dim countVentas = 0
    Dim countServicio = 0
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaClientesCaja.SelectedIndexChanged

    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListaClientesCaja.Items.Add("p")
        Me.ListaClientesCaja.Items.RemoveAt(0)


    End Sub

    'Tipo Ventanilla
    'C      = Caja
    'V      = Ventas
    'S      = Servicio al cliente

    Public Function agregarCliente(tipoVentanilla As String) As Integer
        If tipoVentanilla Is "C" Then
            Me.ListaClientesCaja.Items.Add(
                tipoVentanilla & (countCaja + 1).ToString)
            countCaja = countCaja + 1
            Return countCaja

        ElseIf tipoVentanilla Is "V" Then
            Me.ListaClientesVentas.Items.Add(
                tipoVentanilla & (countVentas + 1).ToString)
            countVentas = countVentas + 1
            Return countVentas
        ElseIf tipoVentanilla Is "S" Then
            Me.ListaClientesServicios.Items.Add(
                tipoVentanilla & (countServicio + 1).ToString)
            countServicio = countServicio + 1
            Return countServicio
        End If
        Return -1
    End Function

    Public Function removerCliente(tipoVentanilla As String) As Integer
        Me.ListaClientesCaja.Items.RemoveAt(0)
        Return 1
    End Function

    Public Function _AgregarALista(tipo) As Integer
        If tipo Is "C" Then
            Me.ListaClientesCaja.Items.Add(
                tipo & (countCaja + 1).ToString)
            countCaja = countCaja + 1
            Return countCaja
        ElseIf tipo Is "V" Then
            Me.ListaClientesVentas.Items.Add(
                tipo & (countVentas + 1).ToString)
            countVentas = countVentas + 1
            Return countVentas
        ElseIf tipo Is "S" Then
            Me.ListaClientesServicios.Items.Add(
                tipo & (countServicio + 1).ToString)
            countServicio = countServicio + 1
            Return countServicio
        End If
    End Function

    Public Function _Siguiente(tipo) As Integer
        If tipo Is "C" Then
            Me.ListaClientesCaja.Items.RemoveAt(0)
            Return Me.ListaClientesCaja.Items.Count
        ElseIf tipo Is "V" Then
            Me.ListaClientesVentas.Items.RemoveAt(0)
            Return Me.ListaClientesVentas.Items.Count
        ElseIf tipo Is "S" Then
            Me.ListaClientesServicios.Items.RemoveAt(0)
            Return Me.ListaClientesServicios.Items.Count
        End If
    End Function


End Class