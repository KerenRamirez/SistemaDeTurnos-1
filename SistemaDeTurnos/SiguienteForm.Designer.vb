<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiguienteForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSiguienteVentas = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnSiguienteServicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSiguienteVentas
        '
        Me.btnSiguienteVentas.Location = New System.Drawing.Point(56, 119)
        Me.btnSiguienteVentas.Name = "btnSiguienteVentas"
        Me.btnSiguienteVentas.Size = New System.Drawing.Size(147, 44)
        Me.btnSiguienteVentas.TabIndex = 0
        Me.btnSiguienteVentas.Text = "Siguiente Ventas"
        Me.btnSiguienteVentas.UseVisualStyleBackColor = True
        '
        'btnCaja
        '
        Me.btnCaja.Location = New System.Drawing.Point(56, 36)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(147, 44)
        Me.btnCaja.TabIndex = 1
        Me.btnCaja.Text = "Siguiente Caja"
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'btnSiguienteServicio
        '
        Me.btnSiguienteServicio.Location = New System.Drawing.Point(56, 200)
        Me.btnSiguienteServicio.Name = "btnSiguienteServicio"
        Me.btnSiguienteServicio.Size = New System.Drawing.Size(147, 44)
        Me.btnSiguienteServicio.TabIndex = 2
        Me.btnSiguienteServicio.Text = "Siguiente Servicio al Cliente"
        Me.btnSiguienteServicio.UseVisualStyleBackColor = True
        '
        'SiguienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 307)
        Me.Controls.Add(Me.btnSiguienteServicio)
        Me.Controls.Add(Me.btnCaja)
        Me.Controls.Add(Me.btnSiguienteVentas)
        Me.MaximumSize = New System.Drawing.Size(304, 346)
        Me.MinimumSize = New System.Drawing.Size(304, 346)
        Me.Name = "SiguienteForm"
        Me.Text = "SiguienteForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSiguienteVentas As Button
    Friend WithEvents btnCaja As Button
    Friend WithEvents btnSiguienteServicio As Button
End Class
