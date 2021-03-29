<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvReserva = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodreserva = New System.Windows.Forms.TextBox()
        Me.txtCodcliente = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtNropersonas = New System.Windows.Forms.TextBox()
        Me.txtObserbaciones = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReserva
        '
        Me.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserva.Location = New System.Drawing.Point(323, 12)
        Me.dgvReserva.Name = "dgvReserva"
        Me.dgvReserva.Size = New System.Drawing.Size(671, 366)
        Me.dgvReserva.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CODIGO DE RESERVA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CODIGO DE CLIENTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA INICIO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FECHA FIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NUMERO DE PERSONAS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "OBSERBACIONES:"
        '
        'txtCodreserva
        '
        Me.txtCodreserva.Location = New System.Drawing.Point(9, 58)
        Me.txtCodreserva.Name = "txtCodreserva"
        Me.txtCodreserva.Size = New System.Drawing.Size(179, 20)
        Me.txtCodreserva.TabIndex = 7
        '
        'txtCodcliente
        '
        Me.txtCodcliente.Location = New System.Drawing.Point(9, 106)
        Me.txtCodcliente.Name = "txtCodcliente"
        Me.txtCodcliente.Size = New System.Drawing.Size(179, 20)
        Me.txtCodcliente.TabIndex = 8
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(9, 153)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(179, 20)
        Me.txtInicio.TabIndex = 9
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(9, 197)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(179, 20)
        Me.txtFinal.TabIndex = 10
        '
        'txtNropersonas
        '
        Me.txtNropersonas.Location = New System.Drawing.Point(9, 250)
        Me.txtNropersonas.Name = "txtNropersonas"
        Me.txtNropersonas.Size = New System.Drawing.Size(179, 20)
        Me.txtNropersonas.TabIndex = 11
        '
        'txtObserbaciones
        '
        Me.txtObserbaciones.Location = New System.Drawing.Point(9, 299)
        Me.txtObserbaciones.Name = "txtObserbaciones"
        Me.txtObserbaciones.Size = New System.Drawing.Size(179, 20)
        Me.txtObserbaciones.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(212, 125)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(212, 181)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(212, 328)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 15
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtObserbaciones)
        Me.Controls.Add(Me.txtNropersonas)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.txtCodcliente)
        Me.Controls.Add(Me.txtCodreserva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReserva)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReserva As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodreserva As TextBox
    Friend WithEvents txtCodcliente As TextBox
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtNropersonas As TextBox
    Friend WithEvents txtObserbaciones As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnListar As Button
End Class
