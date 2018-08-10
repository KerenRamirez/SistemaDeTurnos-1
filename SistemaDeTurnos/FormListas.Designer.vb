<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListaClientesCaja = New System.Windows.Forms.ListBox()
        Me.ListaClientesVentas = New System.Windows.Forms.ListBox()
        Me.ListaClientesServicios = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListaClientesCaja
        '
        Me.ListaClientesCaja.FormattingEnabled = True
        Me.ListaClientesCaja.Location = New System.Drawing.Point(27, 44)
        Me.ListaClientesCaja.Name = "ListaClientesCaja"
        Me.ListaClientesCaja.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesCaja.TabIndex = 0
        '
        'ListaClientesVentas
        '
        Me.ListaClientesVentas.FormattingEnabled = True
        Me.ListaClientesVentas.Location = New System.Drawing.Point(154, 42)
        Me.ListaClientesVentas.Name = "ListaClientesVentas"
        Me.ListaClientesVentas.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesVentas.TabIndex = 1
        '
        'ListaClientesServicios
        '
        Me.ListaClientesServicios.FormattingEnabled = True
        Me.ListaClientesServicios.Location = New System.Drawing.Point(297, 44)
        Me.ListaClientesServicios.Name = "ListaClientesServicios"
        Me.ListaClientesServicios.Size = New System.Drawing.Size(118, 264)
        Me.ListaClientesServicios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ventas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "servicio al cliente"
        '
        'FormListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 348)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListaClientesServicios)
        Me.Controls.Add(Me.ListaClientesVentas)
        Me.Controls.Add(Me.ListaClientesCaja)
        Me.Name = "FormListas"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaClientesCaja As ListBox
    Friend WithEvents ListaClientesVentas As ListBox
    Friend WithEvents ListaClientesServicios As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
