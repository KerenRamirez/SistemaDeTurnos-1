<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCliente
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
        Me.txtNumeroIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nuevoClienteButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButtonCaja = New System.Windows.Forms.RadioButton()
        Me.radioButtonVentas = New System.Windows.Forms.RadioButton()
        Me.radioButtonServicio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumeroIdentidad
        '
        Me.txtNumeroIdentidad.Location = New System.Drawing.Point(42, 159)
        Me.txtNumeroIdentidad.Name = "txtNumeroIdentidad"
        Me.txtNumeroIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroIdentidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Identidad (con guiones)"
        '
        'nuevoClienteButton
        '
        Me.nuevoClienteButton.Location = New System.Drawing.Point(42, 204)
        Me.nuevoClienteButton.Name = "nuevoClienteButton"
        Me.nuevoClienteButton.Size = New System.Drawing.Size(75, 23)
        Me.nuevoClienteButton.TabIndex = 3
        Me.nuevoClienteButton.Text = "Confirmar"
        Me.nuevoClienteButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioButtonServicio)
        Me.GroupBox1.Controls.Add(Me.radioButtonVentas)
        Me.GroupBox1.Controls.Add(Me.radioButtonCaja)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el departamento"
        '
        'radioButtonCaja
        '
        Me.radioButtonCaja.AutoSize = True
        Me.radioButtonCaja.Location = New System.Drawing.Point(7, 20)
        Me.radioButtonCaja.Name = "radioButtonCaja"
        Me.radioButtonCaja.Size = New System.Drawing.Size(46, 17)
        Me.radioButtonCaja.TabIndex = 0
        Me.radioButtonCaja.TabStop = True
        Me.radioButtonCaja.Text = "Caja"
        Me.radioButtonCaja.UseVisualStyleBackColor = True
        '
        'radioButtonVentas
        '
        Me.radioButtonVentas.AutoSize = True
        Me.radioButtonVentas.Location = New System.Drawing.Point(7, 44)
        Me.radioButtonVentas.Name = "radioButtonVentas"
        Me.radioButtonVentas.Size = New System.Drawing.Size(58, 17)
        Me.radioButtonVentas.TabIndex = 1
        Me.radioButtonVentas.TabStop = True
        Me.radioButtonVentas.Text = "Ventas"
        Me.radioButtonVentas.UseVisualStyleBackColor = True
        '
        'radioButtonServicio
        '
        Me.radioButtonServicio.AutoSize = True
        Me.radioButtonServicio.Location = New System.Drawing.Point(7, 68)
        Me.radioButtonServicio.Name = "radioButtonServicio"
        Me.radioButtonServicio.Size = New System.Drawing.Size(110, 17)
        Me.radioButtonServicio.TabIndex = 2
        Me.radioButtonServicio.TabStop = True
        Me.radioButtonServicio.Text = "Servicio Al Cliente"
        Me.radioButtonServicio.UseVisualStyleBackColor = True
        '
        'FormularioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nuevoClienteButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumeroIdentidad)
        Me.Name = "FormularioCliente"
        Me.Text = "FormularioCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumeroIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nuevoClienteButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioButtonServicio As RadioButton
    Friend WithEvents radioButtonVentas As RadioButton
    Friend WithEvents radioButtonCaja As RadioButton
End Class
