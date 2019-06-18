<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbuscarproducto
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
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.cbopcion = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(583, 318)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 11
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Location = New System.Drawing.Point(149, 318)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnseleccionar.TabIndex = 10
        Me.btnseleccionar.Text = "Seleccionar"
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(596, 32)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 9
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'cbopcion
        '
        Me.cbopcion.FormattingEnabled = True
        Me.cbopcion.Location = New System.Drawing.Point(451, 32)
        Me.cbopcion.Name = "cbopcion"
        Me.cbopcion.Size = New System.Drawing.Size(121, 21)
        Me.cbopcion.TabIndex = 8
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(109, 33)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(336, 20)
        Me.txtbuscar.TabIndex = 7
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(51, 77)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(697, 235)
        Me.grilla.TabIndex = 6
        '
        'frmbuscarproducto
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
        Me.Name = "frmbuscarproducto"
        Me.Text = "frmbuscarproducto"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents cbopcion As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents grilla As DataGridView
End Class
