

Public Class MainForm
    Public formularioCliente As New FormularioCliente()
    Public formListas As New FormListas()
    Public form3 As New Form3()
    Public siguienteForm As New SiguienteForm()

    '<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    '<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub mostrarmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrarmenu.Click
        If mostrarmenu.Width = 250 Then
            mostrarmenu.Width = 73
        Else
            mostrarmenu.Width = 250
        End If
    End Sub

    Private Sub iconcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconcerrar.Click
        Application.Exit()
    End Sub

    Private Sub iconmaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconmaximizar.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        iconmaximizar.Visible = False
        iconrestaurar.Visible = True
    End Sub

    Private Sub iconrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconrestaurar.Click
        Me.WindowState = FormWindowState.Normal

        iconrestaurar.Visible = False
        iconmaximizar.Visible = True
    End Sub

    Private Sub iconminimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFormHija(ByVal formhija)
    End Sub

    Private Sub btnbasico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbasico.Click
        If mostrarmenu.Width = 250 Then
            mostrarmenu.Width = 73
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formularioCliente.Visible = False Then formularioCliente.Visible = True Else formularioCliente.Visible = False
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configuranciones de formularioCliente (entrada)
        formularioCliente.TopLevel = False
        formularioCliente.FormBorderStyle = FormBorderStyle.FixedSingle
        formularioCliente.Size = New System.Drawing.Size(300, 300)
        formularioCliente.Location = New System.Drawing.Point(20, 20)
        formularioCliente.WindowState = FormWindowState.Normal
        formularioCliente.Visible = False


        'configuranciones de formListas (pantallas)
        formListas.TopLevel = False
        formListas.FormBorderStyle = FormBorderStyle.FixedSingle
        formListas.Size = New System.Drawing.Size(550, 400)
        formListas.Location = New System.Drawing.Point(350, 20)
        formListas.WindowState = FormWindowState.Normal
        formListas.Visible = False

        'configuranciones de form3 (ventanilla)
        form3.TopLevel = False
        form3.FormBorderStyle = FormBorderStyle.FixedSingle
        form3.Size = New System.Drawing.Size(750, 400)
        form3.Location = New System.Drawing.Point(20, 450)
        form3.WindowState = FormWindowState.Normal
        form3.Visible = False

        'configuranciones de siguienteForm (ventanilla)
        siguienteForm.TopLevel = False
        siguienteForm.FormBorderStyle = FormBorderStyle.FixedSingle
        siguienteForm.Size = New System.Drawing.Size(750, 400)
        siguienteForm.Location = New System.Drawing.Point(800, 450)
        siguienteForm.WindowState = FormWindowState.Normal
        siguienteForm.Visible = False

        'agregar los formularios a el contenedor
        PanelContenedor.Controls.Add(formularioCliente)
        PanelContenedor.Controls.Add(formListas)
        PanelContenedor.Controls.Add(form3)
        PanelContenedor.Controls.Add(siguienteForm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If formListas.Visible = False Then formListas.Visible = True Else formListas.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If form3.Visible = False Then form3.Visible = True Else form3.Visible = False
    End Sub

    Public Sub _AgregarCliente(identidad As String, tipo As String)
        Dim count = formListas._AgregarALista(tipo)
        Dim mensaje = "Numero: " + tipo + count.ToString() + vbCrLf +
                       "Identidad: " + identidad + vbCrLf +
                       DateTime.Now()
        MessageBox.Show(mensaje)
    End Sub

    Public Sub _Siguiente(tipo As String)
        formListas._Siguiente(tipo)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If siguienteForm.Visible = False Then siguienteForm.Visible = True Else siguienteForm.Visible = False
    End Sub
End Class