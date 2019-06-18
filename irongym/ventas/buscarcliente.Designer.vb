<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarcliente
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
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbopcion = New System.Windows.Forms.ComboBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(40, 70)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(697, 235)
        Me.grilla.TabIndex = 0
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(98, 26)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(336, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'cbopcion
        '
        Me.cbopcion.FormattingEnabled = True
        Me.cbopcion.Location = New System.Drawing.Point(440, 25)
        Me.cbopcion.Name = "cbopcion"
        Me.cbopcion.Size = New System.Drawing.Size(121, 21)
        Me.cbopcion.TabIndex = 2
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(585, 25)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Location = New System.Drawing.Point(138, 311)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnseleccionar.TabIndex = 4
        Me.btnseleccionar.Text = "Seleccionar"
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(572, 311)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 5
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'buscarcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 373)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.cbopcion)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.grilla)
        Me.Name = "buscarcliente"
        Me.Text = "Buscar Cliente"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbopcion As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents btnvolver As Button
End Class
